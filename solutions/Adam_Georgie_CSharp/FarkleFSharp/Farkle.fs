module Farkle

open Xunit

let score rolls =
    let rec calc rolls = 
        match rolls with
        | 1::1::1::xs -> 1000 + (calc xs)
        | a::b::c::xs when a = b && b = c -> a * 100 + (calc xs) 
        | 1::xs -> 100 + (calc xs)
        | 5::xs -> 50 + (calc xs)
        | _::xs -> (calc xs)
        | [] -> 0
    
    rolls |> List.sort |> calc

[<Fact>]
let ``1`` () =
    Assert.Equal(100, ([1] |> score) )

[<Fact>]
let ``2`` () =
    Assert.Equal(0, ([2] |> score) )

[<Fact>]
let ``5`` () =
    Assert.Equal(50, ([5] |> score) )



[<Fact>]
let ``1 1`` () =
    Assert.Equal(200, ([1;1] |> score) )

[<Fact>]
let ``1 1 1 is 1000`` () =
    Assert.Equal(1000, ([1;1;1] |> score) )

[<Fact>]
let ``1 1 1 1 is 1100`` () =
    Assert.Equal(1100, ([1;1;1;1] |> score) )

[<Fact>]
let ``2 2 2 2`` () =
    Assert.Equal(200, ([2;2;2;2] |> score) )

[<Fact>]
let ``3 3 3 3`` () =
    Assert.Equal(300, ([3;3;3;3] |> score) )

[<Fact>]
let ``1 2 1 1`` () =
    Assert.Equal(1000, ([1;2;1;1;] |> score) )
