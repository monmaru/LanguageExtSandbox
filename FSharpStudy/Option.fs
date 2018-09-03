module Option

type OptionBuilder() =
  member __.Bind(x, f) =
    match x with
    | Some v -> f v
    | None -> None
  member __.Return(x) = Some x

let option = OptionBuilder()

let tryOption opt1 opt2 opt3 =
  option {
    let! x = opt1
    let! y = opt2
    let! z = opt3
    return x + y + z
  }