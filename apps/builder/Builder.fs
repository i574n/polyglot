#if !INTERACTIVE
namespace Polyglot
#endif

module Builder =

#if !INTERACTIVE
    open Lib
#endif

    open Common
    open SpiralFileSystem.Operators

    /// ## buildProject
    let inline buildProject runtime outputDir path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let fileDir = fullPath |> System.IO.Path.GetDirectoryName
        let extension = fullPath |> System.IO.Path.GetExtension

        trace Debug
            (fun () -> "buildProject")
            (fun () -> $"fullPath: {fullPath} / {_locals ()}")

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
                let command = $@"dotnet publish ""{path}"" --configuration Release --output ""{outputDir}"" --runtime {runtime}"
                let! exitCode, _result =
                    SpiralRuntime.execution_options (fun x ->
                        { x with
                            l1 = command
                            l5 = Some fileDir
                        }
                    )
                    |> SpiralRuntime.execute_with_options_async
                return exitCode
            })
            |> Async.Sequential
            |> Async.map Array.sum
    }

    /// ## persistCodeProject
    let inline persistCodeProject packages modules name hash code = async {
        trace Debug
            (fun () -> "persistCodeProject")
            (fun () -> $"packages: {packages} / modules: {modules} / name: {name} / hash: {hash} / code.Length: {code |> String.length} / {_locals ()}")

        let workspaceRoot = SpiralFileSystem.get_workspace_root ()

        let targetDir =
            let targetDir = workspaceRoot </> "target/polyglot/builder" </> name
            match hash with
            | Some hash -> targetDir </> "packages" </> hash
            | None -> targetDir
        System.IO.Directory.CreateDirectory targetDir |> ignore

        let filePath = targetDir </> $"{name}.fs" |> System.IO.Path.GetFullPath
        do! code |> SpiralFileSystem.write_all_text_exists filePath

        let modulesCode =
            modules
            |> List.map (fun path -> $"""<Compile Include="{workspaceRoot </> path}" />""")
            |> SpiralSm.concat "\n        "

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

    <Import Project="{workspaceRoot}/.paket/Paket.Restore.targets" />
</Project>
"""
        do! fsprojCode |> SpiralFileSystem.write_all_text_exists fsprojPath

        let paketReferencesPath = targetDir </> "paket.references"
        let paketReferencesCode =
            "FSharp.Core" :: packages
            |> SpiralSm.concat "\n"
        do! paketReferencesCode |> SpiralFileSystem.write_all_text_exists paketReferencesPath

        return fsprojPath
    }

    /// ## buildCode
    let inline buildCode runtime packages modules outputDir name code = async {
        let! fsprojPath = code |> persistCodeProject packages modules name None
        let! exitCode = fsprojPath |> buildProject runtime outputDir
        if exitCode > 0 then
            let! fsprojText = fsprojPath |> SpiralFileSystem.read_all_text_async
            trace Critical
                (fun () -> "buildCode")
                (fun () -> $"code: {code |> SpiralSm.ellipsis_end 400} / fsprojText: {fsprojText} / {_locals ()}")
        return exitCode
    }

    /// ## readFile
    let inline readFile path = async {
        let! code = path |> SpiralFileSystem.read_all_text_async

        let code = System.Text.RegularExpressions.Regex.Replace (
            code,
            @"( *)(let\s+main\s+.*?\s*=)",
            fun m -> m.Groups.[1].Value + "[<EntryPoint>]\n" + m.Groups.[1].Value + m.Groups.[2].Value
        )

        let codeTrim = code |> SpiralSm.trim_end [||]
        return
            if codeTrim |> SpiralSm.ends_with "\n()"
            then codeTrim |> SpiralSm.slice 0 ((codeTrim |> String.length) - 3)
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
        return! code |> persistCodeProject packages modules name None
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
