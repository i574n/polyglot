open FParsec


type Block =
    {
        magic : string
        content : string
    }

let magicMarker = pstring "#!"

let magicCommand =
    magicMarker
    >>. manyTill anyChar newline
    |>> (String.Concat >> fun s -> s.Trim ())

let content =
    (newline >>. magicMarker) <|> (eof >>. preturn "")
    |> attempt
    |> lookAhead
    |> manyTill anyChar
    |>> (String.Concat >> fun s -> s.Trim ())

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
        |> Array.map (fun line -> $"// {line.Trim ()}")
        |> String.concat "\n"
    | "fsharp", { magic = "fsharp"; content = content } when 
        (content.StartsWith "//// test"
        || content.StartsWith "//// ignore")
        |> not ->
            content.Split [| '\n' |]
            |> Array.filter (fun line -> line.StartsWith "#r" |> not)
            |> String.concat "\n"
    | _ -> ""

let formatBlocks kernel blocks =
    blocks
    |> List.map (formatBlock kernel)
    |> List.filter (fun s -> s <> "")
    |> String.concat "\n\n"

let run input =
    match run blocks input with
    | Success (result, _, _) -> Result.Ok result
    | Failure (errorMsg, _, _) -> Result.Error errorMsg

let parseDibCode kernel file =
    let input = File.ReadAllText file
    match run input with
    | Result.Ok blocks ->
        blocks
        |> List.filter (fun block -> block.magic = kernel || block.magic = "markdown")
        |> formatBlocks kernel
    | Result.Error msg -> failwith msg

let writeDibCode kernel file =
    printfn $"Parsing {file}"
    let output = parseDibCode kernel file
    let outputFileName =
        match kernel with
        | "fsharp" -> file.Replace (".dib", ".fs")
        | _ -> failwith "Unknown kernel"
    File.WriteAllText (outputFileName, output)

let escapeCell (input : string) =
    input.Split [| '\n' |]
    |> Array.map (fun line ->
        if line.StartsWith "\\#!"
        then System.Text.RegularExpressions.Regex.Replace (line, "^\\\\#!", "#!")
        else line)
    |> String.concat "\n"