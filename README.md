# Selenium Automation Project with Page Object Model (POM)

This project demonstrates how to automate web UI testing using Selenium WebDriver in C# with the Page Object Model (POM) design pattern. It includes a sample test suite for automating login functionality.

## Prerequisites

Before running the tests, ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) or any other compatible IDE
- [JDK](https://www.oracle.com/java/technologies/downloads/) for Allure Report generation
- [Allure Commandline](https://github.com/allure-framework/allure2) installed and added to your PATH

## Installation

1. Clone or download this repository to your local machine.
2. Open the solution file (`LoginPOM.sln`) in Visual Studio.

## Setup

1. Ensure the necessary NuGet packages are installed. If not, restore the packages by right-clicking on the solution and selecting `Restore NuGet Packages`.
2. Build the solution to ensure everything is set up correctly.

## Running the Tests

1. Open Test Explorer in Visual Studio (`Test > Test Explorer`).
2. Click on `Run All` to execute all the tests.

## Project Structure

- **Pages**: Contains page object classes representing different pages of the application.
- **Tests**: Contains test classes for executing automated tests.

## Dependencies

- NUnit: Test framework for writing and executing tests.
- NUnit3TestAdapter: Test adapter for running NUnit tests in Visual Studio.
- Selenium.WebDriver: WebDriver bindings for interacting with web browsers.
- Selenium.Support: Support libraries for Selenium WebDriver.
- WebDriverManager: Library for managing browser drivers.
- DotNetSeleniumExtras.WaitHelpers: Additional Selenium wait helper methods.

## License

This project is licensed under the [MIT License](LICENSE).
