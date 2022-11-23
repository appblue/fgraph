
let orList l =
    List.fold (fun s t -> s || t) false l

let andList l =
    List.fold (fun s t -> s && t) true l

let rec isConnected  g s e =  
    if List.exists (fun ed -> ed = (s,e)) g then
        true
    else
        let st = g |> List.filter (fun ed -> snd ed <> s) 
        in
            [ for ed in st -> isConnected st (snd ed) e ] |> orList


[<EntryPoint>]
let main _ =
    // definition of the directed graph. list of edges connecting nodes
    let dgraph = [
        (1, 2); (2, 3); (2, 4); (3, 1)
        (6, 5); (5, 4); 
    ]

    // different test cases for isConnected
    let query = [(1, 4); (1, 5); (1, 3)]

    // results
    let res = 
        query |> List.map (fun (x,y) -> isConnected dgraph x y)

    
    printfn "graph: %A " dgraph
    printfn "query: %A " query
    printfn "result: %A " res

    0