#if !INTERACTIVE
namespace Polyglot
#endif

module Builder =

    open Common
    open FileSystem

    /// ## buildCode

    let buildCode path name code = async {
        let getLocals () = $"path: {path} / name: {name} / code.Length: {code |> String.length} / {getLocals ()}"
        trace Debug (fun () -> "build") getLocals

        let targetPath = path </> "target"
        System.IO.Directory.CreateDirectory targetPath |> ignore

        let filePath = targetPath </> $"{name}.fs" |> System.IO.Path.GetFullPath
        do! System.IO.File.WriteAllTextAsync (filePath, code) |> Async.AwaitTask

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
        do! System.IO.File.WriteAllTextAsync (fsprojPath, fsprojCode) |> Async.AwaitTask

        let paketReferencesCode = $"FSharp.Core

Argu
FParsec
FSharp.Control.AsyncSeq
NetMQ
System.CommandLine
System.Reactive.Linq
"
        do! System.IO.File.WriteAllTextAsync (targetPath </> "paket.references", paketReferencesCode) |> Async.AwaitTask

        let! exitCode, _result =
            Runtime.executeWithOptionsAsync
                {
                    Command = "dotnet build -c Release"
                    CancellationToken = None
                    OnLine = None
                    WorkingDirectory = Some targetPath
                }

        return exitCode
    }

    let buildFile path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let dir = fullPath |> System.IO.Path.GetDirectoryName
        let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> System.IO.File.ReadAllTextAsync |> Async.AwaitTask

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
