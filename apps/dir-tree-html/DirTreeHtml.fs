#if !INTERACTIVE
namespace Polyglot
#endif

module DirTreeHtml =

    type FileSystemNode =
        | File of string * string
        | Folder of string * string * FileSystemNode list
        | Root of FileSystemNode list

    let rec scanDirectory isRoot (basePath : string) (path : string) =
        let relativePath = path.Replace(basePath, "").Replace("\\", "/").TrimStart '/'
        let folderName = System.IO.Path.GetFileName path
        let subDirectories = System.IO.Directory.GetDirectories path |> Array.toList
        let files = System.IO.Directory.GetFiles path |> Array.toList

        let subDirectoryNodes = subDirectories |> List.map (scanDirectory false basePath)
        let fileNodes = files |> List.map (fun f -> File (System.IO.Path.GetFileName f, relativePath))

        let children = subDirectoryNodes @ fileNodes
        if isRoot
        then Root children
        else Folder (folderName, relativePath, children)

    let rec generateHtml fsNode =
        match fsNode with
        | File (fileName, relativePath) ->
            $"""<li><span>&#128196; <a href="{relativePath}{if relativePath.Length = 0 then "" else "/"}{fileName}">{fileName}</a></span></li>"""
        | Folder (folderName, relativePath, children) ->
            let childrenHtml = children |> List.map generateHtml |> String.concat "\n"
            $"""<li><span>📁 <a href="{relativePath}">{folderName}</a></span><ul>{childrenHtml}</ul></li>"""
        | Root children ->
            children |> List.map generateHtml |> String.concat "\n"

    let generateHtmlForFileSystem root =
        let rootHtml = root |> generateHtml
        $"""<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
</head>
<body>
  <ul>{rootHtml}</ul>
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
