# MarsRoverProblem
##### (This project is open for extension)

## Problem Statement
Rovers are due to land on Mars on a plateau. They will be navigated around the plateau (which is rectangular) by a team back on Earth so they can capture images of their surroundings. 

Their current position is represented by x and y co-ordinates and a letter representing North, East, South or West. The plateau is divided into a grid, so an example position is 0, 0, N, which signifies that the rover is in the bottom left corner facing North. 

To control the rover remotely, three letter commands are available – ‘L’, ‘R’ and ‘M’. ‘L’ and ‘R’ commands make the rover spin 90 degrees left or right respectively without moving forward. The ‘M’ command makes the rover move forward one grid point in the same direction it is already pointing. 

Assume that the square directly North from (x, y) is (x, y+1) and the lower left co-ordinates are 0,0. 

Input: 

There are three inputs. 

1.       The grid upper right boundary co-ordinates. No rover should be able to move off the plateau.  

2.       The rover’s starting position on the plateau. 

3.       The series of instructions given to the rover to get them to explore. 

There are two rovers that have their inputs set at the same time but the second one starts to move when the first has finished moving. 

Output: 

The output for each rover should be its final co-ordinates and orientation. 

#### Test Input: 

5 5 

1 2 N 

LMLMLMLMM 

3 3 E 

MMRMMRMRRM 

#### Expected Output: 

1 3 N 

5 1 E 

## Technical Details Expected: 
* Create a C# .NET application to fulfil the criteria. 
* Use any NuGet packages or third party frameworks you believe to be appropriate. 
* Apply what you would consider to be best practice 

## Functionality incorporated
* XML Comments added for more readability.
* Model Object Rover is created.
* ICommand Interface created for executing command functionality.
* Commands created for the movement/rotation of rover.
* Service Interface added for moving the rover in Sync (MoveRoverSync method).
* Test Project Xunit added to test each Movements and Rover Service.
* Dependency injected at Program.cs

## Functionality may be added in future extension
* MoveRoverAsync can be implemented.
* More Movements can be added
* Mock testing can be added

