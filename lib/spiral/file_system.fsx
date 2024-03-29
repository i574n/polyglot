let rec closure0 () () : string =
    let v0 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let v1 : (unit -> string) = System.IO.Path.GetTempPath
    let v2 : string = v1 ()
    let v3 : string = $"{v0}"
    let v4 : string = System.IO.Path.Combine (v2, v3)
    let v5 : System.DateTime = System.DateTime.Now
    let v6 : System.Guid = System.Guid.NewGuid ()
    let v7 : string = v6.ToString ()
    let v8 : string = v5.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v9 : System.Guid = System.Guid $"{v8}{v7.[v8.Length..]}"
    let v10 : string = v9.ToString ()
    let v11 : string = System.IO.Path.Combine (v4, v10)
    v11
let v0 : (unit -> string) = closure0()
let create_temp_directory_name x = v0 x
()
