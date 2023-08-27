#if !INTERACTIVE
namespace Polyglot
#endif

module Crypto =

    open Common

    /// ## hashText

    let hashText (input : string) =
        use sha256 = System.Security.Cryptography.SHA256.Create ()
        input
        |> System.Text.Encoding.UTF8.GetBytes
        |> sha256.ComputeHash
        |> Array.map (fun b -> b.ToString "x2")
        |> String.concat ""
