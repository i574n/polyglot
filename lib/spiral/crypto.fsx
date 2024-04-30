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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : string = "crypto"
    let v7 : ICryptoCreateHash = Fable.Core.JsInterop.importAll v6
    let v8 : string = "v7.createHash($0)"
    let v9 : string = "sha256"
    let v10 : obj = Fable.Core.JsInterop.emitJsExpr v9 v8
    let v11 : string = "$0.update($1, 'utf8')"
    let v12 : obj = Fable.Core.JsInterop.emitJsExpr struct (v10, v0) v11
    let v13 : string = "$0.digest($1)"
    let v14 : string = "hex"
    let v15 : string = Fable.Core.JsInterop.emitJsExpr struct (v12, v14) v13
    v15
#endif
    
#if FABLE_COMPILER_PYTHON
    let v16 : string = null |> unbox<string>
    v16
#endif
    
#else
    let v17 : (unit -> System.Security.Cryptography.SHA256) = System.Security.Cryptography.SHA256.Create
    let v18 : System.Security.Cryptography.SHA256 = v17 ()
    use v18 = v18 
    let v19 : System.Security.Cryptography.SHA256 = v18 
    let v20 : (string -> (uint8 [])) = System.Text.Encoding.UTF8.GetBytes
    let v21 : (uint8 []) = v20 v0
    let v22 : ((uint8 []) -> (uint8 [])) = v19.ComputeHash
    let v23 : (uint8 []) = v22 v21
    let v24 : int32 = v23.Length
    let v25 : (string []) = Array.zeroCreate<string> (v24)
    let v26 : Mut0 = {l0 = 0} : Mut0
    while method0(v24, v26) do
        let v28 : int32 = v26.l0
        let v29 : uint8 = v23.[int v28]
        let v30 : (string -> string) = v29.ToString
        let v31 : string = "x2"
        let v32 : string = v30 v31
        v25.[int v28] <- v32
        let v33 : int32 = v28 + 1
        v26.l0 <- v33
        ()
    let v34 : string seq = seq { for i = 0 to v25.Length - 1 do yield v25.[i] }
    let v35 : string = method1()
    let v36 : (string -> (string seq -> string)) = String.concat
    let v37 : (string seq -> string) = v36 v35
    let v38 : string = v37 v34
    v38
#endif
    |> fun x -> _v1 <- Some x
    let v39 : string = _v1.Value
    v39
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
()
