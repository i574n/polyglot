namespace Polyglot.FSharp


open FsCheck
open FsCheck.FSharp
// open Expecto

open Expecto
// open Expecto.ExpectoFsCheck
// open FsCheck
// open FsCheck.FSharp
open System
// open System.Threading
// open System.Reflection
// open Microsoft.FSharp.Reflection
// open System.Collections.Generic
open Microsoft.FSharp.Collections

module Main =
    // open Model


    // let lameTask (x:int) =
    //     if x=0 then false else true
    //     |> Tasks.Task.FromResult



    // type TestEnum =
    //     | First = 0
    //     | Second = 1
    //     | Third = 2

    // let testEnum (e:TestEnum) = e = TestEnum.First



    // //bug: label not printed because of exception. Workaround: use lazy.
    // //actually I don't hink this is fixable, as the exception rolls up the stack, so the labelling
    // //that happens when a property "returns" gets bypassed.
    // //this is irritating when using Assert statements from unit testing frameworks though.
    // let labelBug (x:int) =
    //     if x=0 then lazy (failwith "nul") else lazy true
    //     |> Prop.label "bla"

    // //smart shrinking
    // [<StructuredFormatDisplay("{Display}")>]
    // type Smart<'a> =
    //     Smart of int * 'a with
    //         override x.ToString() = match x with Smart (_,a) -> sprintf "%A" a
    //         member x.Display = x.ToString()


    // type SmartShrinker =
    //     static member Smart(value:Arbitrary<'a>) =
    //         let generator = value.Generator |> Gen.map (fun arb -> Smart (0,arb))
    //         let shrinker (Smart (i,x)) =
    //             let ys = Seq.zip {0..Int32.MaxValue} (value.Shrinker x) |> Seq.map Smart
    //             let i' = Math.Max(0,i-2)
    //             let rec interleave left right =
    //                 match (left,right) with
    //                 | ([],rs) -> rs
    //                 | (ls,[]) -> ls
    //                 | (l::ls,r::rs) -> l::r::(interleave ls rs)
    //             interleave (Seq.take i' ys |> Seq.toList) (Seq.skip i' ys |> Seq.toList) |> List.toSeq
    //         Arb.fromGenShrink(generator, shrinker)

    // let smartShrink (Smart (_,i)) = i < 20


    // //-------------examples from QuickCheck paper-------------
    // let revUnit (x:char) = List.rev [x] = [x]

    // let revApp (x:string) xs =
    //     List.rev (x::xs) = List.rev xs @ [x]
    //     |> Prop.trivial (xs = [])
    //     |> Prop.trivial (xs.Length = 1)

    // let prop_MaxLe (x:float) y = (x <= y) ==> (lazy (max  x y = y))

    // //----------various examples-------------------------------

    // //convoluted property, but shows the power of the combinators: it's no problem to return
    // //functions that return properties.

    // //arrays
    // let prop_RevRevArr (xs:int[]) = Array.rev(Array.rev xs) = xs

    // let prop_RevRevArr2 (xs:int[][]) = xs.Rank = 1

    // type ARecord = { XPos : int; YPos : int; Name: string }

    // type ADisc =
    //     | First of int
    //     | Second of char
    //     | Third of ADisc
    //     | Fourth of ADisc[]

    // type Properties =
    //     static member Test1 (b,(b2:bool)) = (b = b2)
    //     static member Test2 i = (i < 100)
    //     static member Test3 (i,j) = (i < 10 && j < 5.1)
    //     static member Test5 (l:list<float>) = List.rev l = l
    //     //this property is falsifiable: sometimes the generator for float generates nan; and nan <> nan
    //     //so when checking the reverse of the reverse list's equality with the original list, the check fails.
    //     static member Test6 (l:list<list<int*int> * float>) = ((l |> List.rev |> List.rev) = l) |> Prop.trivial (List.isEmpty l)
    //     static member Test7 (a:int*bool,b:float*int) = (fst a = snd b)
    //     static member Test8 (l:list<obj>) = ( List.rev l = l)
    //     static member Test9 (s:string) = ( new String(s.ToCharArray()) = s )
    //     static member Test10 i = (i = 'r')
    //     static member NoTest i = "30"
    //     static member OptionTest (o:option<int>) = match o with Some _ -> false | _ -> true

    // //-----------ReflectArbitrary tests------------------------
    // //a record type containing an array type
    // type List<'a> = {list : 'a[]}

    // //a recursive union type containing a record type
    // type Tree<'a> =
    //     | Leaf of string
    //     | Branch of List<Tree<'a>>

    // let rec xmlSafeTree (x : Tree<string>) =
    //     match x with
    //     | Leaf x -> not (x.StartsWith " " && x.EndsWith " ")
    //     | Branch xs -> Array.forall xmlSafeTree xs.list

    // let product (x:int,y:int) = (x > 0 && y > 0) ==> (x*y > 0)

    // let revString (x : string) =
    //     let cs = x.ToCharArray()
    //     Array.Reverse cs
    //     new String(cs)

    // let revRevString x = revString (revString x) = x

    // let private idempotent f x = let y = f x in f y = y

    // let bigTuple (a:bool,b:float,c:string,d:char,e:byte,f:float,g:string,h:option<float>,i) = if i > 10 then false else true

    // //-----property combinators------------------
    // let private withPositiveInteger (p : int -> 'a) = fun n -> n <> 0 ==> lazy (p (abs n))

    // let testProp = withPositiveInteger ( fun x -> x > 0 |> Prop.classify true "bla"  )

    // let testProp2 = withPositiveInteger ( fun x -> withPositiveInteger (fun y -> x + y > 0  ))

    // let blah (s:string) = if s = "" then raise (new System.Exception("foo")) else s.Length > 3

    // let private withNonEmptyString (p : string -> 'a) = Prop.forAll (Gen.elements [ "A"; "AA"; "AAA" ] |> Arb.fromGen) p


    // //-----------------async--------
    // let asyncWork (i :int) =
    //     async {
    //         let s = Async.Sleep i
    //         let c = Async.Sleep 1500
    //         let t =
    //             [s; c]
    //             |> Seq.map Async.StartAsTask
    //             |> System.Threading.Tasks.Task.WhenAny
    //         let! x = Async.AwaitTask t
    //         return true
    //     }
    // // let config = Config.QuickThrowOnFailure.WithParallelRunConfig({ MaxDegreeOfParallelism = 1 })

    // //-----------------test reflective shrinking--------
    // type RecordStuff<'a> = { Yes:bool; Name:'a; NogIets:list<int*char> }

    // // let bigSize = Config.Quick.WithStartSize(100).WithEndSize(100)

    // type Recursive<'a> = Void | Leaf of 'a | Branch of Recursive<'a> * 'a * Recursive<'a>

    // type Simple = Void | Void2 | Void3 | Leaf of int | Leaf2 of string * int *char * float

    // let prop_RevId' (xs:list<int>) (x:int) = if (xs.Length > 2) && (x >10) then false else true


    // //----------Checking toplevel properties trick------------------

    // type Marker = class end

    // type Counter(?initial:int) =
    //     let mutable n = defaultArg initial 0
    //     member __.Inc() =
    //         //silly bug
    //         if n <= 3  then n <- n + 1 else n <- n + 2
    //         n
    //     member __.Dec() = if n <= 0 then failwithf "Precondition fail" else n <- n - 1; n
    //     member __.Reset() = n <- 0
    //     override __.ToString() = sprintf "Counter = %i" n

    // open FsCheck.Experimental

    // let spec =
    //     let inc =
    //         { new Operation<Counter,int>() with
    //             member __.Run m = m + 1
    //             member __.Check (c,m) =
    //                 let res = c.Inc()
    //                 m = res
    //                 |@ sprintf "Inc: model = %i, actual = %i" m res
    //             override __.ToString() = "inc"}
    //     let dec =
    //         { new Operation<Counter,int>() with
    //             member __.Run m = m - 1
    //             override __.Pre m =
    //                 m > 0
    //             member __.Check (c,m) =
    //                 let res = c.Dec()
    //                 m = res
    //                 |@ sprintf "Dec: model = %i, actual = %i" m res
    //             override __.ToString() = "dec"}
    //     let create initialValue =
    //         { new Setup<Counter,int>() with
    //             member __.Actual() = new Counter(initialValue)
    //             member __.Model() = initialValue }
    //     { new Machine<Counter,int>() with
    //         member __.Setup = Gen.choose (0,3) |> Gen.map create |> Arb.fromGen
    //         member __.Next _ = Gen.elements [ inc; dec ] }











    type ValorDado =
        | Um
        | Dois
        | Tres
        | Quatro
        | Cinco
        | Seis

    type Aspecto =
        | Passado of string
        | Presente of string
        | Futuro of string
        | Desafios of string
        | Recursos of string
        | ResultadoProjetado of string
        | InfluenciaExterna of string

    type Contexto =
        | Amor of string
        | Trabalho of string
        | Saude of string
        | Dinheiro of string

    type Universo =
        | Real of string
        | Virtual of string
        | Espiritual of string

    type Caracteristica =
        | Aspecto of Aspecto
        | Contexto of Contexto
        | Universo of Universo
        | DadoRolado of ValorDado

    type Interacao =
        | Conflito
        | Parceria
        | Crescimento
        | Estagnacao
        | Separacao
        | Harmonia
        | Desafio
        | Colaboracao
        | Progresso
        | Mudanca
        | Sucesso

    type Interpretacao =
        | Interpretacao of Caracteristica * Interacao * Caracteristica

    type SistemaDivinacao =
        | SistemaDivinacao of Interpretacao list * Caracteristica

    let config = { FsCheckConfig.defaultConfig with maxTest = 10000 }

    let shuffleList xs seed =
        let rnd = Random (seed)
        xs
        |> List.map (fun x -> rnd.Next(), x)
        |> List.sortBy fst
        |> List.map snd







    type Complexity = Simple | Moderate | Complex
    type Duration = Short | Medium | Long

    type Dice = D1 of int | D2 of int

    type Task =
        | Task of Complexity * Duration * Task
        | NoTask

    let durationOfFocus (d1: int) (d2: int) =
        match d1 + d2 with
        | sum when sum <= 4 -> Short
        | sum when sum <= 8 -> Medium
        | _ -> Long

    let complexityOfTask (d1: int) (d2: int) =
        match d1 * d2 with
        | product when product <= 12 -> Simple
        | product when product <= 24 -> Moderate
        | _ -> Complex

    let rec generateTaskList d1 d2 previousTask =
        match d1, d2 with
        | d1, d2 when d1 > 0 && d2 > 0 ->
            let complexity = complexityOfTask d1 d2
            let duration = durationOfFocus d1 d2
            let newTask = Task (complexity, duration, previousTask)
            generateTaskList (d1 - 1) (d2 - 1) newTask
        | _, _ -> previousTask





























    let properties =
        testList "FsCheck samples" [
            let sistemaDivinacao (interpretacoes: Interpretacao list, caracteristica: Caracteristica) =
                let interpretacoes = interpretacoes |> List.sort
                SistemaDivinacao (interpretacoes, caracteristica)

            testPropertyWithConfig config "SistemaDivinacao is consistent" <|
                fun (interpretacoes: Interpretacao list, caracteristica: Caracteristica) ->
                    sistemaDivinacao (interpretacoes, caracteristica)
                        = sistemaDivinacao (interpretacoes, caracteristica)

            testPropertyWithConfig config "SistemaDivinacao is variant under permutation" <|
                fun (input: Interpretacao list, caracteristica: Caracteristica) ->
                    let seed = 42
                    let shuffledInput = shuffleList input seed
                    sistemaDivinacao (input, caracteristica) = sistemaDivinacao (shuffledInput, caracteristica)

            testPropertyWithConfig config "SistemaDivinacao can handle lists of any size" <|
                fun (input: Interpretacao list, caracteristica: Caracteristica) ->
                    let sistema = sistemaDivinacao (input, caracteristica)
                    sistema <> Unchecked.defaultof<_>

            testPropertyWithConfig config "SistemaDivinacao is invariant under data transformations" <|
                fun (input: Interpretacao list, caracteristica: Caracteristica, newInterpretation: Interpretacao) ->
                    let containsNewInterpretation = input |> List.contains newInterpretation
                    let modifiedInput =
                        if containsNewInterpretation
                        then input
                        else newInterpretation :: input
                    if containsNewInterpretation
                    then sistemaDivinacao (List.sort input, caracteristica)
                            = sistemaDivinacao (List.sort modifiedInput, caracteristica)
                    else sistemaDivinacao (List.sort input, caracteristica)
                            <> sistemaDivinacao (List.sort modifiedInput, caracteristica)








            let focusDurationProperty =
                Prop.forAll (Arb.fromGen (Gen.map2 (fun d1 d2 -> (d1, d2)) (Gen.choose (1, 6)) (Gen.choose (1, 6)))) <| fun (d1, d2) ->
                    let expected =
                        match d1 + d2 with
                        | sum when sum <= 4 -> Short
                        | sum when sum <= 8 -> Medium
                        | _ -> Long
                    let actual = durationOfFocus d1 d2
                    expected = actual

            let taskComplexityProperty =
                Prop.forAll (Arb.fromGen (Gen.map2 (fun d1 d2 -> (d1, d2)) (Gen.choose (1, 6)) (Gen.choose (1, 6)))) <| fun (d1, d2) ->
                    let expected =
                        match d1 * d2 with
                        | product when product <= 12 -> Simple
                        | product when product <= 24 -> Moderate
                        | _ -> Complex
                    let actual = complexityOfTask d1 d2
                    expected = actual

            let taskListLengthProperty =
                Prop.forAll (Arb.fromGen (Gen.map2 (fun d1 d2 -> (d1, d2)) (Gen.choose (1, 6)) (Gen.choose (1, 6)))) <| fun (d1, d2) ->
                    let taskList = generateTaskList d1 d2 NoTask
                    let rec taskListLength taskList =
                        match taskList with
                        | Task (_, _, nextTask) -> 1 + taskListLength nextTask
                        | NoTask -> 0
                    let actual = taskListLength taskList
                    let expected = min d1 d2
                    expected = actual


            testProperty "Duration of focus should be calculated correctly" focusDurationProperty
            testProperty "Task complexity should be calculated correctly" taskComplexityProperty
            testProperty "Task list should have the correct length" taskListLengthProperty



        ]

    [<EntryPoint>]
    let main _ =

        let dice1 = 6
        let dice2 = 6

        let taskList = generateTaskList dice1 dice2 NoTask

        let rec printTaskList taskList =
            match taskList with
            | Task (complexity, duration, nextTask) ->
                printfn "Complexidade: %A, Duração: %A" complexity duration
                printTaskList nextTask
            | NoTask -> ()

        printTaskList taskList


        // Console.WriteLine("--------------------------(-6):");
        // // Check.One({ Config.Quick with replay = Some <| Random.StdGen (1145655947,296144285) }, fun x -> abs x >= 0)
        // Console.WriteLine("--------------------------(-5):");
        // let (.=.) left right = left = right |@ sprintf "%A = %A" left right

        // let testCompare (i:int) (j:int) = 2*i+1  .=. 2*j-1
        // Check.Quick testCompare
        // Console.WriteLine("--------------------------(-4):");

        // Console.WriteLine("--------------------------(-3):");
        // let mapRec (Fun f) (l:list<int>) =
        //     not l.IsEmpty ==>
        //         lazy (List.map f l = ((*f <|*) List.head l) :: List.map f (List.tail l))
        // Check.Quick mapRec
        // Console.WriteLine("--------------------------(-2):");
        // let associativity (x:int) (f:int->float,g:float->char,h:char->int) = ((f >> g) >> h) x = (f >> (g >> h)) x
        // Check.Quick associativity
        // Console.WriteLine("--------------------------(-1):");
        // Check.Quick (StateMachine.toProperty spec)
        // Console.WriteLine("--------------------------0:");
        runTestsWithCLIArgs [] [||] properties |> ignore


        // Console.WriteLine("--------------------------1:");
        // Check.Quick (withNonEmptyString blah)
        // Console.WriteLine("--------------------------2:");
        // Check.Quick testProp2
        // Console.WriteLine("--------------------------3:");
        // Check.Quick lameTask
        // Console.WriteLine("--------------------------4:");
        // Check.Quick testEnum
        // Console.WriteLine("--------------------------5:");
        // Check.Quick labelBug

        // Console.WriteLine("--------------------------6:");
        // // Check.One(Config.Default.WithArbitrary([typeof<SmartShrinker>]), smartShrink)
        // Console.WriteLine("--------------------------7:");
        // Check.Quick (fun b y (x:char,z) -> if b then (fun q -> y+1 = z + int q) else (fun q -> q =10.0))
        // Console.WriteLine("--------------------------8:");
        // Check.Quick prop_RevRevArr
        // Console.WriteLine("--------------------------9:");
        // Check.Quick prop_RevRevArr2

        // Console.WriteLine("--------------------------10:");
        // Check.Quick (fun (arr:int[]) -> Array.rev arr = arr)

        // Console.WriteLine("--------------------------11:");
        // Check.Quick (fun (record:ARecord) -> (record.XPos > 0 && record.YPos > 0) ==> lazy (record.XPos * record.YPos > 0))

        // Console.WriteLine("--------------------------12:");
        // Check.Quick (fun (a:int,b,c,d:int,e,f) (g,h,i) -> a > b && b > c && d > e && f > g && e > f && h > i && a > i)

        // Console.WriteLine("--------------------------13:");
        // Check.Quick (fun (d:ADisc) -> match d with First i -> i = 2 | Second c -> true | Third _ -> true | Fourth _ -> raise <| InvalidOperationException())

        // Console.WriteLine("--------------------------14:");
        // Check.QuickAll<Properties>()

        // Console.WriteLine("--------------------------15:");
        // Check.Quick (idempotent (fun (x : string) -> x.ToUpper()))

        // Console.WriteLine("--------------------------16:");
        // Check.Quick("bigTuple",bigTuple)

        // Console.WriteLine("--------------------------17:");
        // Check.Quick testProp

        // // Console.WriteLine("--------------------------18:");
        // // Check.One (config, asyncWork)

        // // Console.WriteLine("--------------------------19:");
        // // Check.One(bigSize,fun (s:RecordStuff<string>) -> s.Yes)

        // // Console.WriteLine("--------------------------20:");
        // // Check.One(bigSize,fun (s:Recursive<string>) -> match s with  Branch _ -> false | _ -> true)

        // // Console.WriteLine("--------------------------21:");
        // // Check.One(bigSize,fun (s:Simple) -> match s with Leaf2 _ -> false |  _ -> true)

        // // Console.WriteLine("--------------------------22:");
        // // Check.One(bigSize,fun (s:Simple) -> match s with Leaf2 _ -> false | Void3 -> false |  _ -> true)

        // // Console.WriteLine("--------------------------23:");
        // // Check.One(bigSize,fun i -> (-10 < i && i < 0) || (0 < i) && (i < 10 ))

        // Console.WriteLine("--------------------------24:");
        // Check.Quick (fun opt -> match opt with None -> false | Some b  -> b  )

        // Console.WriteLine("--------------------------25:");
        // Check.Quick (fun opt -> match opt with Some n when n<0 -> false | Some n when n >= 0 -> true | _ -> true )

        // Console.WriteLine("--------------------------26:");
        // Check.Quick prop_RevId'

        // Console.WriteLine("--------------------------27:");
        // Check.QuickAll (typeof<Marker>.DeclaringType)

        0
