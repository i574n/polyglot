namespace Polyglot.FSharp

open System

module Main =
    open Model
    open Challenges
    
    [<EntryPoint>]
    let main _ =
        for challenge in challenges do
            printfn ""
            printfn "Test: %s" (challenge.GetType().DeclaringType.FullName.Split('+').[1])
            
            let resultList =
                challenge.Run ()
                |> Seq.toList
                
            let header = [
                { Input = "Input"
                  Expected = "Expected"
                  Result = "Result" }
                
                { Input = "---"
                  Expected = "---"
                  Result = "---" }
            ]
            
            let getWidth fn =
                resultList
                |> List.append header
                |> List.map fn
                |> List.map String.length
                |> List.sortDescending
                |> List.tryHead
                |> Option.defaultValue 0
                
            let inputWidth = getWidth (fun x -> x.Input)
            let expectedWidth = getWidth (fun x -> x.Expected)
            let resultWidth = getWidth (fun x -> x.Result)
            
            let padResult result =
                { Input = result.Input.PadRight inputWidth
                  Expected = result.Expected.PadRight expectedWidth
                  Result = result.Result.PadRight resultWidth }
            
            let header = header |> List.map padResult
            let resultList = resultList |> List.map padResult
            
            let printLine result =
                printfn "%s\t%s\t%s" result.Input result.Expected result.Result
                
            for result in header do
                printLine result
            
            for result in resultList do
                Console.ForegroundColor <-
                    if result.Expected.Trim() <> result.Result.Trim()
                    then ConsoleColor.DarkRed
                    else ConsoleColor.DarkGreen
                    
                printLine result
                
                Console.ResetColor ()
            
        0

