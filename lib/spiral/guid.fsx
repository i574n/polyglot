let rec closure0 () (v0 : string) : System.Guid =
    let v1 : System.Guid = v0 |> System.Guid 
    v1
and closure1 () () : System.Guid =
    let v0 : (unit -> System.Guid) = System.Guid.NewGuid
    v0 ()
let v0 : (string -> System.Guid) = closure0()
let new_guid x = v0 x
let v1 : (unit -> System.Guid) = closure1()
let new_raw_guid x = v1 x
()
