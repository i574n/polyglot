#if !INTERACTIVE
namespace Polyglot
#endif

module Builder =

    open Common
    open FileSystem

    /// ## buildProject

    let buildProject path = async {
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
                    Command = "dotnet build -c Release"
                    CancellationToken = None
                    OnLine = None
                    WorkingDirectory = Some fileDir
                }

        return exitCode
    }

    /// ## buildCode

    let buildCode path name code = async {
        let getLocals () = $"path: {path} / name: {name} / code.Length: {code |> String.length} / {getLocals ()}"
        trace Debug (fun () -> "buildCode") getLocals

        let targetPath = path </> "target"
        System.IO.Directory.CreateDirectory targetPath |> ignore

        let filePath = targetPath </> $"{name}.fs" |> System.IO.Path.GetFullPath
        do! code |> FileSystem.writeAllTextAsync filePath

        let repositoryRoot = path |> FileSystem.findParent ".paket" false

        let fsprojPath = targetPath </> $"{name}.fsproj"
        let fsprojCode = $"""<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
        <LangVersion>preview</LangVersion>
        <RollForward>Major</RollForward>
        <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>
        <Version>0.0.1-alpha.1</Version>
        <OutputType>Exe</OutputType>
    </PropertyGroup>

    <ItemGroup>
        <Compile Include="{repositoryRoot}/nbs/Common.fs" />
        <Compile Include="{repositoryRoot}/nbs/Async.fs" />
        <Compile Include="{repositoryRoot}/nbs/AsyncSeq.fs" />
        <Compile Include="{repositoryRoot}/nbs/Networking.fs" />
        <Compile Include="{repositoryRoot}/nbs/Runtime.fs" />
        <Compile Include="{repositoryRoot}/nbs/FileSystem.fs" />
        <Compile Include="{filePath}" />
    </ItemGroup>

    <Import Project="{repositoryRoot}/.paket/Paket.Restore.targets" />
</Project>
"""
        do! fsprojCode |> FileSystem.writeAllTextAsync fsprojPath

        let paketReferencesCode = $"FSharp.Core

Argu
FParsec
FSharp.Control.AsyncSeq
NetMQ
System.CommandLine
System.Reactive.Linq
"
        do! paketReferencesCode |> FileSystem.writeAllTextAsync (targetPath </> "paket.references")

        return! fsprojPath |> buildProject
    }

    /// ## buildFile

    let buildFile path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let dir = fullPath |> System.IO.Path.GetDirectoryName
        let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> FileSystem.readAllTextAsync

        return! code |> buildCode dir fileName
    }

    /// ## Arguments

    [<RequireQualifiedAccess>]
    type Arguments =
        | [<Argu.ArguAttributes.MainCommand; Argu.ArguAttributes.ExactlyOnce; Argu.ArguAttributes.Last>]
            Paths of paths : string list

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | Paths _ -> nameof Arguments.Paths

    /// ## main

    [<EntryPoint>]
    let main args =
        let argsMap = args |> Runtime.parseArgsMap<Arguments>

        let paths =
            match argsMap.[nameof Arguments.Paths] with
            | [ Arguments.Paths paths ] -> paths
            | _ -> []

        paths
        |> List.map buildFile
        |> Async.Parallel
        |> Async.runWithTimeout 30000
        |> function
            | Some results -> results |> Array.sum
            | None -> 1
