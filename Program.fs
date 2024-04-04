printfn "This is John Carlo Hipolito's Code!"

type Genre = Horror | Drama | Thriller | Comedy | Fantasy | Sport
type Director = { Name: string; Movies: int }
type Movie = { Name: string; RunLength: int; Genre: Genre; Director: Director; IMDBRating: float }

let codaMovie = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Hender"; Movies = 9 }; IMDBRating = 8.1 }
let belfastMovie = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
let dontLookUpMovie = { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; Movies = 27 }; IMDBRating = 7.2 }
let driveMyCarMovie = { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDBRating = 7.6 }
let duneMovie = { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
let kingRichardMovie = { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
let licoricePizzaMovie = { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDBRating = 7.4 }
let nightmareAlleyMovie = { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo del Toro"; Movies = 22 }; IMDBRating = 7.1 }

let movies = [codaMovie; belfastMovie; dontLookUpMovie; driveMyCarMovie; duneMovie; kingRichardMovie; licoricePizzaMovie; nightmareAlleyMovie]
printfn "\nList of Movies:"
printfn "%-20s%10s  %-11s%-25s%-11s" "Movie" "Run Length" "Genre" "Director" "IMDB Rating"
printfn "%s" ("".PadRight(80,'-'))
movies |> List.iter (fun movie -> printfn "%-20s%10i  %-11s%-25s%11.1f" movie.Name movie.RunLength (sprintf $"%A{movie.Genre}") movie.Director.Name movie.IMDBRating)

let probOscarsWinners =
    movies
    |> List.filter (fun movie -> movie.IMDBRating > 7.4)
    |> List.map (fun movie -> movie.Name, movie.IMDBRating)
printfn "\nProbable Oscar Winners:"
printfn "%sIMDB Rating" ("Movie".PadRight 20)
printfn "%s" ("".PadRight(32,'-'))
probOscarsWinners |> List.iter (fun (name, rating) -> printfn $"%s{name.PadRight 20}%11.1f{rating}")

let lengthHMin =
    movies
    |> List.map (fun movie -> movie.Name, movie.RunLength / 60, movie.RunLength % 60)
    |> List.map (fun (name, hours, minutes) -> sprintf "%s%dh %dmin" (name.PadRight 20) hours minutes)
printfn "\nRun Length in '_h __min':"
printfn "%sRun Length" ("Movie".PadRight 20)
printfn "%s" ("".PadRight(31, '-'))
lengthHMin |> List.iter (printfn "%s")

