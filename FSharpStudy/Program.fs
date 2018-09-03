// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Maybe

[<EntryPoint>]
let main _ = 
    let a= Some 3
    let b = Some 2
    let c = Some 4
    match add3 a b c with
    | Some v -> printfn "Some: %A" v
    | None -> printfn "None"
    0
