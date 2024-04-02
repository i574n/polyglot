#if !INTERACTIVE
namespace Polyglot
#endif

module Builder =

#if !INTERACTIVE
    open Lib
#endif

    open Common
    open File_system.Operators

    /// ## buildProject

    let inline buildProject runtime outputDir path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let fileDir = fullPath |> System.IO.Path.GetDirectoryName
        let extension = fullPath |> System.IO.Path.GetExtension

        let getLocals () = $"fullPath: {fullPath} / {getLocals ()}"
        trace Debug (fun () -> "buildProject") getLocals

        match extension with
        | ".fsproj" -> ()
        | _ -> failwith "Invalid project file"

        let runtimes =
            runtime
            |> Option.map List.singleton
            |> Option.defaultValue [ "linux-x64"; "win-x64" ]

        let outputDir = outputDir |> Option.defaultValue "dist"

        return!
            runtimes
            |> List.map (fun runtime -> async {
                let! exitCode, _result =
                    Runtime.executeWithOptionsAsync
                        {
                            Command = $@"dotnet publish ""{path}"" --configuration Release --output ""{outputDir}"" --runtime {runtime}"
                            CancellationToken = None
                            OnLine = None
                            WorkingDirectory = Some fileDir
                        }

                return exitCode
            })
            |> Async.Sequential
            |> Async.map Array.sum
    }

    /// ## persistCodeProject

    let inline persistCodeProject packages modules name code = async {
        let getLocals () = $"packages: {packages} / modules: {modules} / name: {name} / code.Length: {code |> String.length} / {getLocals ()}"
        trace Debug (fun () -> "persistCodeProject") getLocals

        let repositoryRoot = FileSystem.getSourceDirectory () |> FileSystem.findParent ".paket" false

        let targetDir = repositoryRoot </> "target/polyglot/builder" </> name
        System.IO.Directory.CreateDirectory targetDir |> ignore

        let filePath = targetDir </> $"{name}.fs" |> System.IO.Path.GetFullPath
        do! code |> FileSystem.writeAllTextExists filePath

        let modulesCode =
            modules
            |> List.map (fun path -> $"""<Compile Include="{repositoryRoot </> path}" />""")
            |> Sm.concat "\n        "

        let fsprojPath = targetDir </> $"{name}.fsproj"
        let fsprojCode = $"""<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <TargetFramework>net9.0</TargetFramework>
        <LangVersion>preview</LangVersion>
        <RollForward>Major</RollForward>
        <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>
        <PublishAot>false</PublishAot>
        <PublishTrimmed>false</PublishTrimmed>
        <PublishSingleFile>true</PublishSingleFile>
        <SelfContained>true</SelfContained>
        <Version>0.0.1-alpha.1</Version>
        <OutputType>Exe</OutputType>
    </PropertyGroup>

    <ItemGroup>
        {modulesCode}
        <Compile Include="{filePath}" />
    </ItemGroup>

    <Import Project="{repositoryRoot}/.paket/Paket.Restore.targets" />
</Project>
"""
        do! fsprojCode |> FileSystem.writeAllTextExists fsprojPath

        let paketReferencesPath = targetDir </> "paket.references"
        let paketReferencesCode =
            "FSharp.Core" :: packages
            |> Sm.concat "\n"
        do! paketReferencesCode |> FileSystem.writeAllTextExists paketReferencesPath

        return fsprojPath
    }

    /// ## buildCode

    let inline buildCode runtime packages modules outputDir name code = async {
        let! fsprojPath = code |> persistCodeProject packages modules name
        return! fsprojPath |> buildProject runtime outputDir
    }

    /// ## readFile

    let inline readFile path = async {
        let! code = path |> FileSystem.readAllTextAsync

        let code = System.Text.RegularExpressions.Regex.Replace (
            code,
            @"( *)(let\s+main\s+.*?\s*=)",
            fun m -> m.Groups.[1].Value + "[<EntryPoint>]\n" + m.Groups.[1].Value + m.Groups.[2].Value
        )

        let codeTrim = code |> Sm.trim_end [||]
        return
            if codeTrim |> Sm.ends_with "\n()"
            then codeTrim |> Sm.slice 0 ((codeTrim |> String.length) - 3)
            else code
    }

    /// ## buildFile

    let inline buildFile runtime packages modules path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let dir = fullPath |> System.IO.Path.GetDirectoryName
        let name = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> readFile
        return! code |> buildCode runtime packages modules (dir </> "dist" |> Some) name
    }

    /// ## persistFile

    let inline persistFile packages modules path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let name = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> readFile
        return! code |> persistCodeProject packages modules name
    }

    /// ## Arguments

    [<RequireQualifiedAccess>]
    type Arguments =
        | [<Argu.ArguAttributes.MainCommand; Argu.ArguAttributes.ExactlyOnce>] Path of path : string
        | [<Argu.ArguAttributes.Unique>] Packages of packages : string list
        | [<Argu.ArguAttributes.Unique>] Modules of modules : string list
        | [<Argu.ArguAttributes.Unique>] Runtime of runtime : string
        | [<Argu.ArguAttributes.Unique>] Persist_Only

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | Path _ -> nameof Path
                | Packages _ -> nameof Packages
                | Modules _ -> nameof Modules
                | Runtime _ -> nameof Runtime
                | Persist_Only -> nameof Persist_Only

    /// ## main

    let main args =
        let argsMap = args |> Runtime.parseArgsMap<Arguments>

        let path =
            match argsMap.[nameof Arguments.Path] with
            | [ Arguments.Path path ] -> Some path
            | _ -> None
            |> Option.get

        let packages =
            match argsMap |> Map.tryFind (nameof Arguments.Packages) with
            | Some [ Arguments.Packages packages ] -> packages
            | _ -> []

        let modules =
            match argsMap |> Map.tryFind (nameof Arguments.Modules) with
            | Some [ Arguments.Modules modules ] -> modules
            | _ -> []

        let runtime =
            match argsMap |> Map.tryFind (nameof Arguments.Runtime) with
            | Some [ Arguments.Runtime runtime ] -> Some runtime
            | _ -> None

        let persistOnly = argsMap |> Map.containsKey (nameof Arguments.Persist_Only)

        if persistOnly
        then path |> persistFile packages modules |> Async.map (fun _ -> 0)
        else path |> buildFile runtime packages modules
        |> Async.runWithTimeout (60000 * 60)
        |> function
            | Some exitCode -> exitCode
            | None -> 1
