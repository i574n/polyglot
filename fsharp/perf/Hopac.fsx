// https://www.demystifyfp.com/fsharp/blog/concurrent-programming-in-fsharp-using-hopac-part-1/
#r "nuget: Hopac"

open Hopac

let helloWorldJob = job {
  printfn "Hello, World!"
}

run helloWorldJob


let longerHelloWorldJob = job {
  do! timeOutMillis 2000
  printfn "Hello, World!"
}

#time "on"
run longerHelloWorldJob
#time "off"

printfn $"end"
