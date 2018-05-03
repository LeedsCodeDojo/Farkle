module tests

open NUnit.Framework
open FsUnit
open scorer

let single die = [die]
let triple die = [die;die;die]
let quad die = [die;die;die;die]

let scores = 
    [
        (single 1, 100);
        (single 5, 50);
        (triple 1, 1000)
        (triple 2, 200);
        (triple 3, 300);
        (quad 1, 2000);
        (quad 2, 400)
    ] |> Map.ofList


[<Test>]
let ``single die scores correctly``() = 
    score scores [1] |> should equal scores.[single 1]
    score scores [5] |> should equal scores.[single 5]

[<Test>]
let ``no scoring dice scores correctly``() = 
    score scores [2;3;4] |> should equal 0

[<Test>]
let ``scoring die in middle scores correctly``() = 
    score scores [2;1;4;2;6] |> should equal scores.[single 1]
    score scores [2;2;4;5;6] |> should equal scores.[single 5]

[<Test>]
let ``triple dice score correctly``() = 
    score scores [2;2;2] |> should equal scores.[triple 2]
    score scores [3;3;3] |> should equal scores.[triple 3]

[<Test>]
let ``triple dice in middle score correctly``() = 
    score scores [3;2;2;2;4] |> should equal scores.[triple 2]

[<Test>]
let ``multiple single dice score correctly``() = 
    score scores [1;1] |> should equal (scores.[single 1] + scores.[single 1])
    score scores [1;3;5] |> should equal (scores.[single 5] + scores.[single 1])

[<Test>]
let ``triple and single dice score correctly``() = 
    score scores [1;2;2;2;5] |> should equal (scores.[triple 2] + scores.[single 1] + scores.[single 5])

[<Test>]
let ``same multiple and single dice score correctly``() = 
    score scores [1;1;1;1;1] |> should equal (scores.[quad 1] + scores.[single 1])

[<Test>]
let ``four of a kind score correctly``() = 
    score scores [2;2;2;2] |> should equal scores.[quad 2]

[<Test>]
let ``out of order muptiples score correctly``() = 
    score scores [2;3;2;4;2] |> should equal scores.[triple 2]

    