# Are You Fat? - BMI Calculator

This is a simple WPF application that calculates the Body Mass Index (BMI) based on user input.

## Features

- User-friendly interface with large text and rounded buttons.
- Calculates BMI based on user's age, height, and weight.
- Displays the calculated BMI in a message box.

## Prerequisites

- .NET Core 3.1 or later
- Windows 10

## Building the Application

1. Open the solution in JetBrains Rider.
2. Go to the `Build` menu and select `Build Solution`.

The executable file will be in the `bin\Debug` or `bin\Release` directory of the project, depending on your build configuration.

## Running the Application

Navigate to the `bin\Debug` or `bin\Release` directory in your project folder and double-click the `.exe` file.

## Publishing the Application

To create a standalone executable file that includes all the dependencies, use the .NET Core's `publish` command with the `-r` (runtime identifier) and `--self-contained true` options:

```bash
dotnet publish -c Release -r win10-x64 --self-contained true