#if !INTERACTIVE
namespace Polyglot
#endif

module Builder =

    open Common
    open FileSystem.Operators

    /// ## buildProject

    let inline buildProject runtime path = async {
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

        return!
            runtimes
            |> List.map (fun runtime -> async {
                let! exitCode, _result =
                    Runtime.executeWithOptionsAsync
                        {
                            Command = $@"dotnet publish ""{path}"" --configuration Release --output ../dist --runtime {runtime}"
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

    let inline persistCodeProject packages modules dir name code = async {
        let getLocals () = $"packages: {packages} / modules: {modules} / dir: {dir} / name: {name} / code.Length: {code |> String.length} / {getLocals ()}"
        trace Debug (fun () -> "persistCodeProject") getLocals

        let targetDir = dir </> "target"
        System.IO.Directory.CreateDirectory targetDir |> ignore

        let filePath = targetDir </> $"{name}.fs" |> System.IO.Path.GetFullPath
        do! code |> FileSystem.writeAllTextExists filePath

        let repositoryRoot = FileSystem.getSourceDirectory () |> FileSystem.findParent ".paket" false

        let modulesCode =
            modules
            |> List.map (fun path -> $"""<Compile Include="{repositoryRoot </> path}" />""")
            |> String.concat "\n        "

        let fsprojPath = targetDir </> $"{name}.fsproj"
        let fsprojCode = $"""<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
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
            |> String.concat "\n"
        do! paketReferencesCode |> FileSystem.writeAllTextExists paketReferencesPath

        return fsprojPath
    }

    /// ## buildCode

    let inline buildCode runtime packages modules dir name code = async {
        let! fsprojPath = code |> persistCodeProject packages modules dir name
        return! fsprojPath |> buildProject runtime
    }

    /// ## readFile

    let inline readFile path = async {
        let! code = path |> FileSystem.readAllTextAsync

        let code = System.Text.RegularExpressions.Regex.Replace (
            code,
            @"( *)(let\s+main\s+.*?\s*=)",
            fun m -> m.Groups.[1].Value + "[<EntryPoint>]\n" + m.Groups.[1].Value + m.Groups.[2].Value
        )

        return
            if code |> String.endsWith "\n()\n"
            then code |> String.substring 0 ((code |> String.length) - 3)
            else code
    }

    /// ## buildFile

    let inline buildFile runtime packages modules path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let dir = fullPath |> System.IO.Path.GetDirectoryName
        let name = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> readFile
        return! code |> buildCode runtime packages modules dir name
    }

    /// ## persistFile

    let inline persistFile packages modules path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let dir = fullPath |> System.IO.Path.GetDirectoryName
        let name = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> readFile
        return! code |> persistCodeProject packages modules dir name
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
        |> Async.runWithTimeout 60000
        |> function
            | Some exitCode -> exitCode
            | None -> 1
