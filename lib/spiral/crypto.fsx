type ICryptoCreateHash = abstract createHash: x: string -> obj
type Mut0 = {mutable l0 : int32}
let rec method0 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method1 () : string =
    let v0 : string = ""
    v0
and closure0 () (v0 : string) : string =
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = null |> unbox<string>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : string = null |> unbox<string>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = null |> unbox<string>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : (unit -> System.Security.Cryptography.SHA256) = System.Security.Cryptography.SHA256.Create
    let v7 : System.Security.Cryptography.SHA256 = v6 ()
    use v7 = v7 
    let v8 : System.Security.Cryptography.SHA256 = v7 
    let v9 : (string -> (uint8 [])) = System.Text.Encoding.UTF8.GetBytes
    let v10 : (uint8 []) = v9 v0
    let v11 : ((uint8 []) -> (uint8 [])) = v8.ComputeHash
    let v12 : (uint8 []) = v11 v10
    let v13 : int32 = v12.Length
    let v14 : (string []) = Array.zeroCreate<string> (v13)
    let v15 : Mut0 = {l0 = 0} : Mut0
    while method0(v13, v15) do
        let v17 : int32 = v15.l0
        let v18 : uint8 = v12.[int v17]
        let v19 : (string -> string) = v18.ToString
        let v20 : string = "x2"
        let v21 : string = v19 v20
        v14.[int v17] <- v21
        let v22 : int32 = v17 + 1
        v15.l0 <- v22
        ()
    let v23 : string seq = seq { for i = 0 to v14.Length - 1 do yield v14.[i] }
    let v24 : string = method1()
    let v25 : (string -> (string seq -> string)) = String.concat
    let v26 : (string seq -> string) = v25 v24
    let v27 : string = v26 v23
    v27
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v28 : string = "crypto"
    let v29 : ICryptoCreateHash = Fable.Core.JsInterop.importAll v28
    let v30 : string = "v29.createHash($0)"
    let v31 : string = "sha256"
    let v32 : obj = Fable.Core.JsInterop.emitJsExpr v31 v30
    let v33 : string = "$0.update($1, 'utf8')"
    let v34 : obj = Fable.Core.JsInterop.emitJsExpr struct (v32, v0) v33
    let v35 : string = "$0.digest($1)"
    let v36 : string = "hex"
    let v37 : string = Fable.Core.JsInterop.emitJsExpr struct (v34, v36) v35
    v37
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v38 : string = Unchecked.defaultof<string>
    v38
#endif
    |> fun x -> _v1 <- Some x
    let v39 : string = _v1.Value
    v39
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
()
