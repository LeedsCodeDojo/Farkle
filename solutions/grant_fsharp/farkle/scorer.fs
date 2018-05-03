module scorer

let score (scores: Map<int list,int>) dice = 

    let rec score' = function
        | [] -> 0
        | w::_::_::z::tail when w = z ->
            scores.[[w;w;w;w]] + score' tail
        | x::_::z::tail when x = z ->
            scores.[[x;x;x]] + score' tail
        | head::tail ->
            match scores.TryFind(head::[]) with
            | Some(x) -> x + score' tail
            | None -> score' tail

    score' (List.sort dice)
