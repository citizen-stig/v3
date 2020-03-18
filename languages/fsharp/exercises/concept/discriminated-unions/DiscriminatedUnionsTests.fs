module DiscriminatedUnionsTests

open FsUnit.Xunit
open Xunit

open DiscriminatedUnions

[<Fact>]
let ``Rate board game``() = rateActivity BoardGame |> should equal No

[<Fact>]
let ``Rate chilling``() = rateActivity Chill |> should equal No

[<Fact>]
let ``Rate crime movie``() = rateActivity (Movie Crime) |> should equal No

[<Fact>]
let ``Rate horror movie``() = rateActivity (Movie Horror) |> should equal No

[<Fact>]
let ``Rate romance movie``() = rateActivity (Movie Romance) |> should equal Yes

[<Fact>]
let ``Rate thriller movie``() = rateActivity (Movie Thriller) |> should equal No

[<Fact>]
let ``Rate Korean restaurant``() = rateActivity (Restaurant Korean) |> should equal Yes

[<Fact>]
let ``Rate Turkish restaurant``() = rateActivity (Restaurant Turkish) |> should equal Maybe

[<Fact>]
let ``Rate walk of 1 mile``() = rateActivity (Walk 1) |> should equal Yes

[<Fact>]
let ``Rate walk of 2 miles``() = rateActivity (Walk 2) |> should equal Yes

[<Fact>]
let ``Rate walk of 3 miles``() = rateActivity (Walk 3) |> should equal Maybe

[<Fact>]
let ``Rate walk of 4 miles``() = rateActivity (Walk 4) |> should equal Maybe

[<Fact>]
let ``Rate walk of 5 miles``() = rateActivity (Walk 5) |> should equal No

[<Fact>]
let ``Rate walk over 5 miles``() = rateActivity (Walk 8) |> should equal No
