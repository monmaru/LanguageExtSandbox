// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Maybe

let add3 opt1 opt2 opt3 =
  maybe {
    let! x = opt1
    let! y = opt2
    let! z = opt3
    return x + y + z
  }

[<EntryPoint>]
let main _ = 
    let a= Some 3
    let b = Some 2
    let c = Some 4
    match add3 a b c with
    | Some v -> printfn "Some: %A" v
    | None -> printfn "None"
    0
