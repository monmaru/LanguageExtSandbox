// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Option

[<EntryPoint>]
let main _ = 
    let x = Some 3
    let y = Some 2
    let z = Some 4
    let opt = tryOption x y z
    match opt with
    | Some v -> printfn "Some: %A" v
    | None -> printfn "None"
    0
