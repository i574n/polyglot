#if !INTERACTIVE
namespace Polyglot
#endif

module Builder =

    open Common
    open FileSystem

    let build path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let dir = fullPath |> System.IO.Path.GetDirectoryName
        let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let extension = fullPath |> System.IO.Path.GetExtension

        let getLocals () = $"dir: {dir} / fileName: {fileName} / extension: {extension} / {getLocals ()}"
        trace Debug (fun () -> "build") getLocals

        let targetPath =
            dir </> "target"

        let fsprojPath =
            targetPath </> $"{fileName}.fsproj"

        let repoRoot =
            let rec loop dir =
                if dir </> ".paket" |> System.IO.Directory.Exists
                then dir
                else dir |> System.IO.Directory.GetParent |> fun x -> x.FullName |> loop
            loop dir

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
        <Compile Include="{repoRoot}/nbs/Common.fs" />
        <Compile Include="{repoRoot}/nbs/Async.fs" />
        <Compile Include="{repoRoot}/nbs/AsyncSeq.fs" />
        <Compile Include="{repoRoot}/nbs/Runtime.fs" />
        <Compile Include="{repoRoot}/nbs/FileSystem.fs" />
        <Compile Include="{fullPath}" />
    </ItemGroup>

    <Import Project="{repoRoot}/.paket/Paket.Restore.targets" />
</Project>
"""
        System.IO.Directory.CreateDirectory targetPath |> ignore

        let paketReferencesCode = $"FSharp.Core

Argu
FParsec
FSharp.Control.AsyncSeq
System.CommandLine
System.Reactive.Linq
"

        do! System.IO.File.WriteAllTextAsync (targetPath </> "paket.references", paketReferencesCode) |> Async.AwaitTask

        do! System.IO.File.WriteAllTextAsync (fsprojPath, fsprojCode) |> Async.AwaitTask

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

    [<RequireQualifiedAccess>]
    type Arguments =
        | [<Argu.ArguAttributes.MainCommand; Argu.ArguAttributes.ExactlyOnce; Argu.ArguAttributes.Last>]
            Paths of paths : string list

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | Paths _ -> nameof Arguments.Paths

    [<EntryPoint>]
    let main args =
        let paths =
            match args |> Runtime.parseArgs<Arguments> with
            | [ Arguments.Paths paths ] -> paths
            | _ -> []

        paths
        |> List.map build
        |> Async.Parallel
        |> Async.RunSynchronously
        |> Array.sum
