let nl = Environment.NewLine

let escapeCell (input : string) =
    input.Split [| '\n' |]
    |> Array.map (function
        | line when line.StartsWith "\\#!" -> System.Text.RegularExpressions.Regex.Replace (line, "^\\\\#!", "#!")
        | line -> line
    )
    |> String.concat "\n"

module String =
    let trim (input : string) =
        input.Trim ()