
type Rover()= 
    member this.Accelerate(speed) = printf "accelerate to speed=%i" speed
    member this.Rotate(degrees) = printf "rotate left with %i degreees" degrees

type Command = 
    Command of (Rover -> unit)

let BreakCommand = 
    Command(fun rover -> rover.Accelerate(-1))

let TurnLeftCommand = 
    Command(fun rover -> rover.Rotate(-5))