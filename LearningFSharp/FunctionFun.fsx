
let swap (x, y) = (y, x)

let rotations (x, y, z) =
    [   (x, y, z);
        (z, x, y);
        (y, z, x);]

let reduce f (x, y, z) = f x + f y + f z

let rec fib x =
    if x < 2 then 1
    else fib (x-1) + fib(x-2)

let results = Array.map fib[|1..40|]

printfn "results= %A" results

let data = (1, 2, 3)

let f (a, b, c) =
    let sum = a + b + c
    let g x = sum + x*x
    (g a, g b, g c)

//Anonymous function value
(fun x -> x + 1)

//Declare a function value
let f1 x = x + 1

//A pair of function values
(f1, f1)

//A function type -> Cannot use val in implementation file
//val f2 : int -> int

//Pipeline
(1 , 2) |> swap

open System.IO

let files = Directory.GetFiles(@"C:\", "*.*", SearchOption.AllDirectories)
let totalSize =
    files
    |> Array.map (fun file -> FileInfo file)
    |> Array.map (fun info -> info.Length)
    |> Array.sum