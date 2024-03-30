#if !INTERACTIVE
namespace Polyglot
#endif

module DibParser =

#if !INTERACTIVE
    open Lib
#endif

    open Common
    open FParsec

    /// ## magicMarker

    let magicMarker : Parser<string, unit> = pstring "#!"

    /// ## magicCommand

    let magicCommand =
        magicMarker
        >>. manyTill anyChar newline
        |>> (System.String.Concat >> Sm.trim)

    /// ## content

    let content =
        (newline >>. magicMarker) <|> (eof >>. preturn "")
        |> attempt
        |> lookAhead
        |> manyTill anyChar
        |>> (System.String.Concat >> Sm.trim)

    /// ## Block

    type Block =
        {
            magic : string
            content : string
        }

    /// ## block

    let block =
        pipe2
            magicCommand
            content
            (fun magic content ->
                {
                    magic = magic
                    content = content
                })

    /// ## blocks

    let blocks =
        skipMany newline
        >>. sepEndBy block (skipMany1 newline)

    /// ## Output

    type Output =
        | Fs
        | Md
        | Spi
        | Spir

    let inline kernelOutputs magic =
        match magic with
        | "fsharp" -> [ Fs ]
        | "markdown" -> [ Md ]
        | "spiral" -> [ Spi; Spir ]
        | _ -> []

    /// ## formatBlock

    let inline formatBlock output (block : Block) =
        match output, block with
        | output, { magic = "markdown"; content = content } ->
            let markdownComment =
                match output with
                | Spi | Spir -> "// // "
                | Fs -> "/// "
                | _ -> ""
            content
            |> Sm.split "\n"
            |> Array.map (Sm.trim_end [||])
            |> Array.filter (Sm.ends_with " (test)" >> not)
            |> Array.map (function
                | "" -> markdownComment |> Sm.trim
                | line -> System.Text.RegularExpressions.Regex.Replace (line, "^\\s*", $"$&{markdownComment}")
            )
            |> Sm.concat "\n"
        | Fs, { magic = "fsharp"; content = content } ->
            let trimmedContent = content |> Sm.trim
            if trimmedContent |> Sm.starts_with "//// test" || trimmedContent |> Sm.starts_with "//// ignore"
            then ""
            else
                content
                |> Sm.split "\n"
                |> Array.filter (Sm.trim_start [||] >> Sm.starts_with "#r" >> not)
                |> Sm.concat "\n"
        | (Spi | Spir), { magic = "spiral"; content = content } ->
            let trimmedContent = content |> Sm.trim
            if trimmedContent |> Sm.starts_with "// // test" || trimmedContent |> Sm.starts_with "// // ignore"
            then ""
            else content
        | _ -> ""

    /// ## formatBlocks

    let inline formatBlocks output blocks =
        blocks
        |> List.map (formatBlock output)
        |> List.filter ((<>) "")
        |> Sm.concat "\n\n"
        |> fun s -> s + "\n"

    /// ## parse

    let inline parse output input =
        match run blocks input with
        | Success (blocks, _, _) ->
            let blocks =
                blocks
                |> List.filter (fun block ->
                    block.magic |> kernelOutputs |> List.contains output || block.magic = "markdown"
                )

            match blocks with
            | { magic = "markdown"; content = content } :: _
                when output = Fs
                && content |> Sm.starts_with "# "
                && content |> Sm.ends_with ")"
                ->
                let inline indentBlock (block : Block) =
                    { block with
                        content =
                            block.content
                            |> Sm.split "\n"
                            |> Array.fold
                                (fun (lines, isMultiline) line ->
                                    let trimmedLine = line |> Sm.trim
                                    if trimmedLine = ""
                                    then "" :: lines, isMultiline
                                    else
                                        let inline singleQuoteLine () =
                                            trimmedLine |> Seq.sumBy ((=) '"' >> System.Convert.ToInt32) = 1
                                            && trimmedLine |> Sm.contains @"'""'" |> not
                                            && trimmedLine |> Sm.ends_with "{" |> not
                                            && trimmedLine |> Sm.ends_with "{|" |> not
                                            && trimmedLine |> Sm.starts_with "}" |> not
                                            && trimmedLine |> Sm.starts_with "|}" |> not

                                        match isMultiline, trimmedLine |> Sm.split_string [| $"{q}{q}{q}" |] with
                                        | false, [| _; _ |] ->
                                            $"    {line}" :: lines, true

                                        | true, [| _; _ |] ->
                                            line :: lines, false

                                        | false, _ when singleQuoteLine () ->
                                            $"    {line}" :: lines, true

                                        | false, _ when line |> Sm.starts_with "#" && block.magic = "fsharp" ->
                                            line :: lines, false

                                        | false, _ ->
                                            $"    {line}" :: lines, false

                                        | true, _ when singleQuoteLine () && line |> Sm.starts_with "    " ->
                                            $"    {line}" :: lines, false

                                        | true, _ when singleQuoteLine () ->
                                            line :: lines, false

                                        | true, _ ->
                                            line :: lines, true
                                )
                                ([], false)
                            |> fst
                            |> List.rev
                            |> Sm.concat "\n"
                    }

                let moduleName, namespaceName =
                    System.Text.RegularExpressions.Regex.Match (content, @"# (.*) \((.*)\)$")
                    |> fun m -> m.Groups.[1].Value, m.Groups.[2].Value

                let moduleBlock =
                    {
                        magic = "fsharp"
                        content =
                            $"#if !INTERACTIVE
namespace {namespaceName}
#endif

module {moduleName} ="
                    }

                blocks
                |> List.indexed
                |> List.fold
                    (fun blocks (index, block) ->
                        match index with
                        | 0 -> blocks
                        | 1 -> indentBlock block :: moduleBlock :: blocks
                        | _ -> indentBlock block :: blocks
                    )
                    []
                |> List.rev
            | _ -> blocks
            |> Result.Ok
        | Failure (errorMsg, _, _) -> Result.Error errorMsg

    /// ## parseDibCode

    let inline parseDibCode output file = async {
        let getLocals () = $"output: {output} / file: {file} / {getLocals ()}"
        trace Debug (fun () -> "parseDibCode") getLocals
        let! input = file |> FileSystem.readAllTextAsync
        match parse output input with
        | Result.Ok blocks -> return blocks |> formatBlocks output
        | Result.Error msg -> return failwith msg
    }

    /// ## writeDibCode

    let inline writeDibCode output path = async {
        let getLocals () = $"output: {output} / path: {path} / {getLocals ()}"
        trace Debug (fun () -> "writeDibCode") getLocals
        let! result = parseDibCode output path
        let outputPath = path |> Sm.replace ".dib" $".{output |> string |> Sm.to_lower}"
        do! result |> FileSystem.writeAllTextAsync outputPath
    }

    /// ## Arguments

    [<RequireQualifiedAccess>]
    type Arguments =
        | [<Argu.ArguAttributes.MainCommand; Argu.ArguAttributes.Mandatory>]
            File of file : string * Output

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | File _ -> nameof File

    /// ## main

    let main args =
        let argsMap = args |> Runtime.parseArgsMap<Arguments>

        let files =
            argsMap.[nameof Arguments.File]
            |> List.map (function
                | Arguments.File (path, output) -> path, output
            )

        files
        |> List.map (fun (path, output) -> path |> writeDibCode output)
        |> Async.Parallel
        |> Async.Ignore
        |> Async.runWithTimeout 30000
        |> function
            | Some () -> 0
            | None -> 1
