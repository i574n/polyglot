#if !INTERACTIVE
namespace Polyglot
#endif

module CommonFSharp =

    open Common

    /// ## getUnionCaseName

    let getUnionCaseName (x: 'T) =
        match Reflection.FSharpValue.GetUnionFields(x, typeof<'T>) with
        | case, _ -> case.Name
