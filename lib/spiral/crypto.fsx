type ICryptoCreateHash = abstract createHash: x: string -> obj
type Mut0 = {mutable l0 : int32}
let rec method0 (v0 : string) : string =
    v0
and method1 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method2 () : string =
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
    let v17 : string = method0(v0)
    let v18 : (unit -> System.Security.Cryptography.SHA256) = System.Security.Cryptography.SHA256.Create
    let v19 : System.Security.Cryptography.SHA256 = v18 ()
    use v19 = v19 
    let v20 : System.Security.Cryptography.SHA256 = v19 
    let v21 : (string -> (uint8 [])) = System.Text.Encoding.UTF8.GetBytes
    let v22 : (uint8 []) = v21 v17
    let v23 : ((uint8 []) -> (uint8 [])) = v20.ComputeHash
    let v24 : (uint8 []) = v23 v22
    let v25 : int32 = v24.Length
    let v26 : (string []) = Array.zeroCreate<string> (v25)
    let v27 : Mut0 = {l0 = 0} : Mut0
    while method1(v25, v27) do
        let v29 : int32 = v27.l0
        let v30 : uint8 = v24.[int v29]
        let v31 : (string -> string) = v30.ToString
        let v32 : string = "x2"
        let v33 : string = v31 v32
        v26.[int v29] <- v33
        let v34 : int32 = v29 + 1
        v27.l0 <- v34
        ()
    let v35 : string seq = seq { for i = 0 to v26.Length - 1 do yield v26.[i] }
    let v36 : string = method2()
    let v37 : (string -> (string seq -> string)) = String.concat
    let v38 : (string seq -> string) = v37 v36
    let v39 : string = v38 v35
    v39
#endif
    |> fun x -> _v1 <- Some x
    let v40 : string = _v1.Value
    v40
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
()
