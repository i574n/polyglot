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
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = null |> unbox<string>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : string = null |> unbox<string>
    v3 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : string = null |> unbox<string>
    v4 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : (unit -> System.Security.Cryptography.SHA256) = System.Security.Cryptography.SHA256.Create
    let v6 : System.Security.Cryptography.SHA256 = v5 ()
    use v6 = v6 
    let v7 : System.Security.Cryptography.SHA256 = v6 
    let v8 : (string -> (uint8 [])) = System.Text.Encoding.UTF8.GetBytes
    let v9 : (uint8 []) = v8 v0
    let v10 : ((uint8 []) -> (uint8 [])) = v7.ComputeHash
    let v11 : (uint8 []) = v10 v9
    let v12 : int32 = v11.Length
    let v13 : (string []) = Array.zeroCreate<string> (v12)
    let v14 : Mut0 = {l0 = 0} : Mut0
    while method0(v12, v14) do
        let v16 : int32 = v14.l0
        let v17 : uint8 = v11.[int v16]
        let v18 : (string -> string) = v17.ToString
        let v19 : string = "x2"
        let v20 : string = v18 v19
        v13.[int v16] <- v20
        let v21 : int32 = v16 + 1
        v14.l0 <- v21
        ()
    let v22 : string seq = seq { for i = 0 to v13.Length - 1 do yield v13.[i] }
    let v23 : string = method1()
    let v24 : (string -> (string seq -> string)) = String.concat
    let v25 : (string seq -> string) = v24 v23
    let v26 : string = v25 v22
    v26 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "crypto"
    let v28 : ICryptoCreateHash = Fable.Core.JsInterop.importAll v27
    let v29 : string = "v28.createHash($0)"
    let v30 : string = "sha256"
    let v31 : obj = Fable.Core.JsInterop.emitJsExpr v30 v29
    let v32 : string = "$0.update($1, 'utf8')"
    let v33 : obj = Fable.Core.JsInterop.emitJsExpr struct (v31, v0) v32
    let v34 : string = "$0.digest($1)"
    let v35 : string = "hex"
    let v36 : string = Fable.Core.JsInterop.emitJsExpr struct (v33, v35) v34
    v36 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v37 : string = Unchecked.defaultof<string>
    v37 
    #endif
    |> fun x -> _v1 <- Some x
    let v38 : string = _v1.Value
    v38
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
()
