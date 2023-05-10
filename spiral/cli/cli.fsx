let rec method0 (v0 : Option<Types.std.string.String>) : Option<Types.std.string.String> =
    v0
and method1 (v0 : Types.std.string.String) : Types.std.string.String =
    v0
and closure1 () (v0 : Types.std.string.String) : string =
    let v1 : Types.std.string.String = method1(v0)
    let v2 : string = "fable_library_rust::String_::fromString(v1)"
    let v3 : string = Fable.Core.Rust.emitExpr () v2
    v3
and closure0 () () : int32 =
    let v0 : string = "test1"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v1
    let v3 : string = "String::from(v2)"
    let v4 : Types.std.string.String = Fable.Core.Rust.emitExpr () v3
    let v5 : Option<Types.std.string.String> = Some v4
    let v6 : Option<Types.std.string.String> = method0(v5)
    let v7 : string = "v6.map(&*$0)"
    let v8 : (Types.std.string.String -> string) = closure1()
    let v9 : Option<string> = Fable.Core.Rust.emitExpr v8 v7
    let v10 : string = "format!(\"{:?}\", $0)"
    let v11 : Types.std.string.String = Fable.Core.Rust.emitExpr v9 v10
    System.Console.WriteLine v11
    let v12 : string = "test2"
    let v13 : string = "r#\"" + v12 + "\"#"
    let v14 : Types.Ref<Types.Str> = Fable.Core.Rust.emitExpr () v13
    let v15 : string = "String::from(v14)"
    let v16 : Types.std.string.String = Fable.Core.Rust.emitExpr () v15
    let v17 : string = "$0"
    let v18 : Types.Ref<Types.std.string.String> = Fable.Core.Rust.emitExpr v16 v17
    let v19 : Option<Types.Ref<Types.std.string.String>> = Some v18
    let v20 : Types.std.string.String = Fable.Core.Rust.emitExpr v19 v10
    System.Console.WriteLine v20
    0
let v0 : (unit -> int32) = closure0()
()
