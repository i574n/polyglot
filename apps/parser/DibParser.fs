open FParsec

type Block =
    {
        magic : string
        content : string
    }

let magicMarker : Parser<string, unit> = pstring "#!"

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
        content.Split [| '\n' |]
        |> Array.map (fun line -> line.TrimEnd ())
        |> Array.filter (fun line -> line.EndsWith " (test)" |> not)
        |> Array.map (function
            | "" -> "//"
            | line -> System.Text.RegularExpressions.Regex.Replace (line, "^\\s*", "$&// ")
        )
        |> String.concat "\n"
    | "fsharp", { magic = "fsharp"; content = content } ->
        let trimmedContent = content.Trim ()
        if trimmedContent.StartsWith "//// test" || trimmedContent.StartsWith "//// ignore"
        then ""
        else
            content.Split [| '\n' |]
            |> Array.filter (fun line -> line.TrimStart().StartsWith "#r" |> not)
            |> String.concat "\n"
    | _ -> ""

let formatBlocks kernel blocks =
    blocks
    |> List.map (formatBlock kernel)
    |> List.filter (fun s -> s <> "")
    |> String.concat "\n\n"
    |> fun s -> s + "\n"

let parse kernel input =
    match run blocks input with
    | Success (blocks, _, _) ->
        let indentBlock (block : Block) =
            { block with
                content =
                    block.content.Split [| '\n' |]
                    |> Array.map (fun line ->
                        if line.TrimEnd () = ""
                        then ""
                        else $"    {line}"
                    )
                    |> String.concat "\n"
            }

        let blocks = blocks |> List.filter (fun block -> block.magic = kernel || block.magic = "markdown")
        
        match blocks with
        | { magic = "markdown"; content = content } :: _
            when kernel = "fsharp"
            && content.StartsWith "# "
            && content.EndsWith ")"
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
                    | 0 -> block :: blocks
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
        | "fsharp" -> file.Replace (".dib", ".fs")
        | _ -> failwith "Unknown kernel"
    File.WriteAllText (outputFileName, output)
