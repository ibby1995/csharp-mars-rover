# Mars Rover

A terminal app for moving Rovers around on the surface of Mars.

## Description

This application simulates NASA-style rover exploration on Mars. Rovers are landed on a plateau and given a series of movement instructions. The app processes these instructions and reports the final position of each rover.

## Project Structure

The solution is split into clean layers:

- **Input Layer** - Parses raw string input into custom data types
- **Logic Layer** - Handles rover movement and rotation
- **Console App** - Entry point that coordinates the layers

## Requirements

- .NET 8.0
- Visual Studio 2022

## How to Run

1. Clone the repository:
```bash
   git clone <YOUR_GITHUB_REPO_URL>
```

2. Open `MarsRover.sln` in Visual Studio 2022

3. Set `MarsRover.Console` as the startup project

4. Press `Ctrl + F5` to run

## How to Run Tests

1. Open **Test Explorer** in Visual Studio (Test → Test Explorer)
2. Click **Run All Tests**

## Input Format

- Line 1: Plateau size (width height)
- Line 2: Rover landing position (x y direction)
- Line 3: Rover instructions (L = turn left, R = turn right, M = move forward)

## Example Output

## Author

Ebrahim