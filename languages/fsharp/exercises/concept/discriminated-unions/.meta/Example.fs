module DiscriminatedUnions

type Approval =
    | Yes
    | No
    | Maybe

type Cuisine =
    | Korean
    | Turkish

type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity activity =
    match activity with
    | Restaurant Korean -> Yes
    | Restaurant Turkish -> Maybe
    | Movie Romance -> Yes
    | Movie _ -> No
    | Walk miles when miles < 3 -> Yes
    | Walk miles when miles < 5 -> Maybe
    | Walk _ -> No
    | _ -> No
