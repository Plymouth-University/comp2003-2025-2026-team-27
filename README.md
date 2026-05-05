[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/xGnTrW1S)
[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=20947264)
# LMS Modernization Project

This project is a modernization of a legacy Library Management System (LMS). It transitions from a legacy infrastructure to a modern web application built on **.NET 9**.

## Security and Data Privacy (Important)

**PLEASE NOTE:** This project is designed to integrate with a private legacy database containing sensitive company and borrower information. For security and privacy reasons, the live database and its specific data records are **not included** in this repository.

Because the application relies on these private SQL Server databases, **it will not run "out of the box"** without a properly configured environment and access to the legacy data schema. If you require a live demonstration or assistance in setting up a local environment with mock data to verify functionality, please contact the project team.

## Project Structure

The solution consists of three main projects:

- **LmsModernApp**: The primary ASP.NET Core MVC web application. It handles user interface, authentication (Staff/Operator), and high-level business logic.
- **Lms.Data**: The Data Access Layer (DAL). It contains Entity Framework Core DbContexts and repositories for interacting with multiple legacy databases (Decat, Delib, Delocal, Deweb, Destats, Dereport).
- **Lms.Tests**: A suite of unit and integration tests to ensure system stability and correctness of data operations.

## Prerequisites

- **.NET 9 SDK**: Ensure you have the latest .NET 9 SDK installed.
- **SQL Server**: The project is configured to work with multiple SQL Server databases.
- **Visual Studio 2022** (recommended) or **VS Code**.

## Setup and Configuration

### 1. Database Connection Strings

The application connects to several databases. You must configure these connection strings in `LmsModernApp/appsettings.json`. Replace the placeholders with your actual SQL Server details:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=LmsModernApp;User Id=sa;Password=YOUR_PASSWORD;...",
  "DelibConnection": "Server=YOUR_SERVER;Database=DELIB;...",
  "CatConnection": "Server=YOUR_SERVER;Database=DECAT;...",
  "LocalConnection": "Server=YOUR_SERVER;Database=DELOCAL;...",
  "WebConnection": "Server=YOUR_SERVER;Database=DEWEB;...",
  "StatsConnection": "Server=YOUR_SERVER;Database=DESTATS;...",
  "ReportConnection": "Server=YOUR_SERVER;Database=DEREPORT;..."
}
```

### 2. Apply Migrations

Apply the Identity migrations to initialize the application's local database (DefaultConnection):

```bash
dotnet ef database update --project LmsModernApp
```

### 3. Legacy Databases

The project assumes the existence of several legacy databases (e.g., `DECAT`, `DELIB`, `DELOCAL`). These databases should be available and populated according to the schema defined in `Lms.Data`.

## Key Features

- **Catalogue Management:** Search, view, edit, and delete catalogue entries.
- **Borrower Management:** Manage library members, including borrower import services.
- **Dashboard:** At-a-glance view of system metrics and status.
- **Circulation & Stock:** Tools for managing stock items and library circulation.
- **Legacy Integration:** Seamlessly interacts with multiple existing legacy database schemas.

## How to Run

### Using Visual Studio
1. Open `LmsModernization.sln`.
2. Set `LmsModernApp` as the Startup Project.
3. Press **F5** to run the application.

### Using Command Line
Navigate to the root directory and run:

```bash
dotnet run --project LmsModernApp
```

The application will default to the login page (`/Account/Login`).

## Authentication

The project uses a custom authentication system for Staff/Operators.
- **Validation:** Operators are validated against the `Operators` table in the `DELOCAL` database.
- **Note:** Currently, the system uses plain-text password comparison for legacy compatibility.

## Testing

To run the test suite, use the following command from the root directory:

```bash
dotnet test
```

## Technologies Used

- **ASP.NET Core 9.0 (MVC)**
- **Entity Framework Core 9.0**
- **SQL Server**
- **Identity Framework** (for internal application state)
- **xUnit** (for testing)
