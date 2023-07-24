#if !INTERACTIVE
namespace Polyglot
#endif

module DibParser =

    open Common
    open FParsec

    type Block =
        {
            magic : string
            content : string
        }

    /// ## magicMarker

    let magicMarker : Parser<string, unit> = pstring "#!"

    /// ## magicCommand

    let magicCommand =
        magicMarker
        >>. manyTill anyChar newline
        |>> (String.Concat >> String.trim)

    let content =
        (newline >>. magicMarker) <|> (eof >>. preturn "")
        |> attempt
        |> lookAhead
        |> manyTill anyChar
        |>> (String.Concat >> String.trim)

    let block =
        pipe2
            magicCommand
            content
            (fun magic content ->
                {
                    magic = magic
                    content = content
                })

    let blocks =
        skipMany newline
        >>. sepEndBy block (skipMany1 newline)

    let formatBlock kernel (block : Block) =
        match kernel, block with
        | _, { magic = "markdown"; content = content } ->
            content
            |> String.split [| '\n' |]
            |> Array.map (String.trimEnd [||])
            |> Array.filter (String.endsWith " (test)" >> not)
            |> Array.map (function
                | "" -> "///"
                | line -> System.Text.RegularExpressions.Regex.Replace (line, "^\\s*", "$&/// ")
            )
            |> String.concat "\n"
        | "fsharp", { magic = "fsharp"; content = content } ->
            let trimmedContent = content |> String.trim
            if trimmedContent |> String.startsWith "//// test" || trimmedContent |> String.startsWith "//// ignore"
            then ""
            else
                content
                |> String.split [| '\n' |]
                |> Array.filter (String.trimStart [||] >> String.startsWith "#r" >> not)
                |> String.concat "\n"
        | _ -> ""

    let formatBlocks kernel blocks =
        blocks
        |> List.map (formatBlock kernel)
        |> List.filter ((<>) "")
        |> String.concat "\n\n"
        |> fun s -> s + "\n"

    let parse kernel input =
        match run blocks input with
        | Success (blocks, _, _) ->
            let indentBlock (block : Block) =
                { block with
                    content =
                        block.content
                        |> String.split [| '\n' |]
                        |> Array.map (fun line ->
                            if line |> String.trimEnd [||] = ""
                            then ""
                            else $"    {line}"
                        )
                        |> String.concat "\n"
                }

            let blocks = blocks |> List.filter (fun block -> block.magic = kernel || block.magic = "markdown")

            match blocks with
            | { magic = "markdown"; content = content } :: _
                when kernel = "fsharp"
                && content |> String.startsWith "# "
                && content |> String.endsWith ")"
                ->
                let moduleName, namespaceName =
                    System.Text.RegularExpressions.Regex.Match (content, @"# (.*) \((.*)\)$")
                    |> fun m -> m.Groups.[1].Value, m.Groups.[2].Value

                let moduleBlock =
                    {
                        magic = "fsharp"
                        content =
                            $"""#if !INTERACTIVE
    namespace {namespaceName}
    #endif

    module {moduleName} ="""
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

    let parseDibCode kernel file =
        let input = File.ReadAllText file
        match parse kernel input with
        | Result.Ok blocks -> blocks |> formatBlocks kernel
        | Result.Error msg -> failwith msg

    let writeDibCode kernel file =
        printfn $"Parsing {file}"
        let output = parseDibCode kernel file
        let outputFileName =
            match kernel with
            | "fsharp" -> file |> String.replace ".dib" ".fs"
            | _ -> failwith "Unknown kernel"
        File.WriteAllText (outputFileName, output)
