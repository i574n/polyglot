#if !INTERACTIVE
namespace Polyglot
#endif

module DirTreeHtml =

    open FileSystem

    type FileSystemNode =
        | File of string * string * int64
        | Folder of string * string * FileSystemNode list
        | Root of FileSystemNode list

    let rec scanDirectory isRoot (basePath : string) (path : string) =
        let relativePath = path.Replace(basePath, "").Replace("\\", "/").TrimStart '/'

        let directories =
            path
            |> System.IO.Directory.GetDirectories
            |> Array.toList
            |> List.sort
            |> List.map (scanDirectory false basePath)
        let files =
            path
            |> System.IO.Directory.GetFiles
            |> Array.toList
            |> List.sort
            |> List.map (fun f -> File (System.IO.Path.GetFileName f, relativePath, System.IO.FileInfo(f).Length))

        let children = directories @ files
        if isRoot
        then Root children
        else Folder (path |> System.IO.Path.GetFileName, relativePath, children)

    let rec generateHtml fsNode =
        match fsNode with
        | File (fileName, relativePath, size) ->
            let size =
                match float size with
                | size when size > 1024.0 * 1024.0 -> $"%.2f{size / 1024.0 / 1024.0} MB"
                | size when size > 1024.0 -> $"%.2f{size / 1024.0} KB"
                | size -> $"%.2f{size} B"
            $"""
<div class="file">&#128196;
  <a href="{relativePath}{if relativePath.Length = 0 then "" else "/"}{fileName}">{fileName}</a>
  <span>&nbsp;({size})</span>
</div>
"""
        | Folder (folderName, relativePath, children) ->
            $"""
<details open>
  <summary>
    <span>&#128194; <a href="{relativePath}">{folderName}</a></span>
  </summary>
  <div class="children">{children |> List.map generateHtml |> String.concat "\n"}</div>
</details>"""
        | Root children ->
            $"""<div>{children |> List.map generateHtml |> String.concat "\n"}</div>"""

    let generateHtmlForFileSystem root =
        $"""<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <style>
.file {{
    display: flex;
}}
.file > span {{
    display: none;
}}
.file:hover > span {{
    display: block;
}}
.children {{
  padding-left: 18px;
  display: flex;
  flex-direction: column;
}}
  </style>
</head>
<body>
  {root |> generateHtml}
</body>
</html>
"""

    /// ## Arguments

    [<RequireQualifiedAccess>]
    type Arguments =
        | [<Argu.ArguAttributes.ExactlyOnce>] Dir of string
        | [<Argu.ArguAttributes.ExactlyOnce>] Html of string

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | Dir _ -> nameof Arguments.Dir
                | Html _ -> nameof Arguments.Html

    /// ## main

    let main args =
        let argsMap = args |> Runtime.parseArgsMap<Arguments>

        let dir =
            match argsMap.[nameof Arguments.Dir] with
            | [ Arguments.Dir dir ] -> Some dir
            | _ -> None
            |> Option.get

        let htmlPath =
            match argsMap.[nameof Arguments.Html] with
            | [ Arguments.Html html ] -> Some html
            | _ -> None
            |> Option.get

        let fileSystem = scanDirectory true dir dir
        let html = generateHtmlForFileSystem fileSystem

        html |> FileSystem.writeAllTextAsync htmlPath
        |> Async.runWithTimeout 30000
        |> function
            | Some () -> 0
            | None -> 1
