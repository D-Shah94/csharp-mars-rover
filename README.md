# Mars Rover

## Overview
This project is a terminal-based application designed to simulate navigating robotic rovers across the surface of Mars. 
The primary focus of this sprint is to demonstrate **Professional Code** standards by implementing a **Layered Architecture** 
and using **Test-Driven Development (TDD)** to ensure the system is robust and easily maintainable.

By separating the application into distinct layers, the "logic" of the rover remains independent of how the user provides input,
whether that be via a terminal, a file, or a web interface.

---

## Project Architecture
The application is organised into several layers to ensure a clean separation of concerns:

* **Models / Domain Layer (Completed)**: Defines the core data types used throughout the app, including enums for `Instruction` 
and `CardinalDirection`, and data classes for `Position` and `PlateauSize`.
* **Input Layer (Completed)**: Responsible for parsing raw strings (e.g. "1 2 N") into the clean domain objects defined in the
Models layer. This ensures the rest of the app doesn't have to deal with "stringly-typed" data.
* **Logic Layer (In Progress)**: This will handle the movement and rotation algorithms, ensuring rovers stay within the bounds
of the plateau.
* **UI Layer (Planned)**: A terminal interface that will handle user interaction, display the plateau, and manage the application
state using a Finite State Machine for graceful error recovery.

---

## Installation & Setup
To run this project on your local machine, ensure you have the **.NET SDK** installed.

1.  **Clone the repository**:
    ```bash
    git clone https://github.com/D-Shah94/csharp-mars-rover.git
    cd csharp-mars-rover
    ```
2.  **Initialise and Restore**:
    ```bash
    dotnet restore
    ```
3.  **Build the Project**:
    ```bash
    dotnet build
    ```

---

## Testing
This project heavily utilises **NUnit** for unit testing, following the TDD "Red-Green-Refactor" cycle.

* **Unit Tests**: Validate individual components like the `InputParser` to ensure valid inputs return the correct domain objects
and invalid inputs are handled correctly.
* **Integration Tests**: Designed to verify that the Input and Logic layers work together seamlessly to produce the expected final rover positions.

To run the full test suite, use the following command:
```bash
dotnet test
```

---

## Roadmap & Progress
* [x] **Project Setup**: Initialised solution with NUnit test project and Git configuration.
* [x] **Domain Modelling**: Created enums and data classes for Plateau and Rover states.
* [x] **Input Parsing**: Implemented and tested parsers for instructions, coordinates, and directions.
* [ ] **Movement Logic**: Implement `Rover.Move()` and `Rover.Rotate()` methods using TDD.
* [ ] **UI Implementation**: Build the terminal loop and state machine to handle interactive user input.
* [ ] **Error Handling**: Finalise logic to ensure the program never crashes on bad input, but instead prompts the user to try again.

---
