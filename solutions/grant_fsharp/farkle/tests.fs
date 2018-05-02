module tests

open NUnit.Framework
open FsUnit
open scorer

[<Test>]
let ``single die scores correctly``() = 
    score [1] |> should equal 100