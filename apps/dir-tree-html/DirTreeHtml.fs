#if !INTERACTIVE
namespace Polyglot
#endif

module DirTreeHtml =

    open FileSystem
    open Feliz.ViewEngine

    type FileSystemNode =
        | File of string * string * int64
        | Folder of string * string * FileSystemNode list
        | Root of FileSystemNode list

    let rec scanDirectory isRoot (basePath : string) (path : string) =
        let relativePath = path.Replace(basePath, "").Replace("\\", "/").Replace("//", "/").TrimStart '/'

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
        let sizeLabel size =
            match float size with
            | size when size > 1024.0 * 1024.0 -> $"%.2f{size / 1024.0 / 1024.0} MB"
            | size when size > 1024.0 -> $"%.2f{size / 1024.0} KB"
            | size -> $"%.2f{size} B"
        match fsNode with
        | File (fileName, relativePath, size) ->
            Html.div [
                prop.children [
                    Html.rawText "&#128196; "
                    Html.a [
                        prop.href $"""{relativePath}{if relativePath = "" then "" else "/"}{fileName}"""
                        prop.text fileName
                    ]
                    Html.span [
                        prop.text $" ({size |> sizeLabel})"
                    ]
                ]
            ]
        | Folder (folderName, relativePath, children) ->
            let size =
                let rec loop children =
                    children
                    |> List.sumBy (function
                        | File (_, _, size) -> size
                        | Folder (_, _, children)
                        | Root children -> loop children
                    )
                loop children
            Html.details [
                prop.isOpen true
                prop.children [
                    Html.summary [
                        prop.children [
                            Html.rawText "&#128194; "
                            Html.a [
                                prop.href relativePath
                                prop.text folderName
                            ]
                            Html.span [
                                prop.text $" ({size |> sizeLabel})"
                            ]
                        ]
                    ]
                    Html.div [
                        prop.children [
                            yield! children |> List.map generateHtml
                        ]
                    ]
                ]
            ]
        | Root children ->
            Html.div [
                prop.children [
                    yield! children |> List.map generateHtml
                ]
            ]

    let generateHtmlForFileSystem root =
        $"""<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <style>
a {{
  font-size: 15px;
}}
span {{
  font-size: 11px;
}}
div > div {{
  padding-left: 10px;
}}
details > div {{
  padding-left: 19px;
}}
  </style>
</head>
<body>
  {root |> generateHtml |> Render.htmlView}
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
