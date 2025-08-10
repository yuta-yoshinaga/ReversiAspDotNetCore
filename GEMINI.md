# GEMINI.md
This file provides guidance to GEMINI when working with code in this repository.

## High-level code architecture and structure

This is an ASP.NET Core 3.1 web application that implements a Reversi game.

- The backend is written in C# and handles the game logic.
- The frontend is built with HTML, CSS, and JavaScript (jQuery) and is located in the `wwwroot` directory.
- The main application logic is in `ReversiAspDotNetCore/`.
- The server-side game logic is implemented in the `ReversiAspDotNetCore/Model/` directory.
- `ReversiController.cs` is the main controller that handles requests from the frontend.
- The application uses a session to store the game state.
- The project can be run with Docker.

## Commonly used commands

### .NET CLI

- **Build the application:**
  ```sh
  dotnet build
  ```
- **Run the application:**
  ```sh
  dotnet run --project ReversiAspDotNetCore/ReversiAspDotNetCore.csproj
  ```

### Docker

- **Build and run the application with Docker Compose:**
  ```sh
  docker-compose up --build
  ```
- **Run in detached mode:**
  ```sh
  docker-compose up --build -d
  ```
- **Stop the application:**
  ```sh
  docker-compose down
  ```
