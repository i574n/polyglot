#if !INTERACTIVE
namespace Polyglot
#endif

module Builder =

    open Common
    open FileSystem

    /// ## buildProject

    let inline buildProject path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let fileDir = fullPath |> System.IO.Path.GetDirectoryName
        let extension = fullPath |> System.IO.Path.GetExtension

        let getLocals () = $"fullPath: {fullPath} / {getLocals ()}"
        trace Debug (fun () -> "buildProject") getLocals

        match extension with
        | ".fsproj" -> ()
        | _ -> failwith "Invalid project file"

        let! exitCode, _result =
            Runtime.executeWithOptionsAsync
                {
                    Command = "dotnet publish -c release -o dist"
                    CancellationToken = None
                    OnLine = None
                    WorkingDirectory = Some fileDir
                }

        return exitCode
    }

    /// ## persistCodeProject

    let inline persistCodeProject packages modules path name code = async {
        let getLocals () = $"packages: {packages} / modules: {modules} / path: {path} / name: {name} / code.Length: {code |> String.length} / {getLocals ()}"
        trace Debug (fun () -> "persistCodeProject") getLocals

        let targetPath = path </> "target"
        System.IO.Directory.CreateDirectory targetPath |> ignore

        let filePath = targetPath </> $"{name}.fs" |> System.IO.Path.GetFullPath
        do! code |> FileSystem.writeAllTextExists filePath

        let repositoryRoot = FileSystem.getSourceDirectory () |> FileSystem.findParent ".paket" false

        let modulesCode =
            modules
            |> List.map (fun path -> $"""<Compile Include="{repositoryRoot </> path}" />""")
            |> String.concat "\n        "

        let fsprojPath = targetPath </> $"{name}.fsproj"
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

        let paketReferencesPath = targetPath </> "paket.references"
        let paketReferencesCode =
            "FSharp.Core" :: packages
            |> String.concat "\n"
        do! paketReferencesCode |> FileSystem.writeAllTextExists paketReferencesPath

        return fsprojPath
    }

    /// ## buildCode

    let inline buildCode packages modules path name code = async {
        let! fsprojPath = persistCodeProject packages modules path name code
        return! fsprojPath |> buildProject
    }

    /// ## buildFile

    let inline buildFile packages modules path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let dir = fullPath |> System.IO.Path.GetDirectoryName
        let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> FileSystem.readAllTextAsync

        let code = System.Text.RegularExpressions.Regex.Replace (
            code,
            @"( *)(let\s+main\s+.*?\s*=)",
            fun m -> m.Groups.[1].Value + "[<EntryPoint>]\n" + m.Groups.[1].Value + m.Groups.[2].Value
        )

        return! code |> buildCode packages modules dir fileName
    }

    /// ## Arguments

    [<RequireQualifiedAccess>]
    type Arguments =
        | [<Argu.ArguAttributes.MainCommand; Argu.ArguAttributes.ExactlyOnce>] Path of path : string
        | [<Argu.ArguAttributes.Unique>] Packages of packages : string list
        | [<Argu.ArguAttributes.Unique>] Modules of modules : string list

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | Path _ -> nameof Arguments.Path
                | Packages _ -> nameof Arguments.Packages
                | Modules _ -> nameof Arguments.Modules

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

        path
        |> buildFile packages modules
        |> Async.runWithTimeout 30000
        |> function
            | Some exitCode -> exitCode
            | None -> 1
