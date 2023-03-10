#if !INTERACTIVE
namespace Polyglot
#endif

module Toml =

    open Common

    let inline (/./) (table: Tomlyn.Model.TomlTable) (key: string) : Tomlyn.Model.TomlTable =
        table.[key] :?> Tomlyn.Model.TomlTable

    let inline (/../) (table: Tomlyn.Model.TomlTable) (key: string) : 'T seq =
        table.[key] :?> Tomlyn.Model.TomlArray |> Seq.cast<'T>
