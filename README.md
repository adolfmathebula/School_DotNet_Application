# SchoolAPI and Client DotNet Application

A school management system built with **ASP.NET Core** and **Blazor**.  
The solution contains two main projects:

- **SchoolApi** – ASP.NET Core Web API for managing students, courses, enrollments, and subjects.
- **SchoolClient** – Blazor client application for interacting with the API.


###  Tech Stack
- C# / .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- Blazor

---

### Project Structure

```
School_DotNet_Application/
│
├── SchoolApi/           # ASP.NET Core Web API
│   ├── Controllers/     # API controllers
│   ├── Models/          # Entity models
│   ├── Program.cs       # Entry point
│   └── appsettings.json # Configuration
│
├── SchoolClient/        # Blazor Client Application
│   ├── Pages/           # UI pages
│   ├── Services/        # Service classes for API calls
│   ├── wwwroot/         # Static files
│   └── Program.cs       # Entry point
│
├── .gitignore
├── README.md
└── School_DotNet_Application.sln
```

---

### Run the API
```bash
cd SchoolApi
dotnet run
```

### Run the Client
```bash
cd SchoolClient
dotnet run
```

---

### Features
- Manage Students, Courses, Subjects, and Enrollments.
- API built with **Entity Framework Core**.
- Client UI built with **Blazor**.
- Configurable through `appsettings.json`.

---

### Notes
- Run EF Core migrations from the **SchoolApi** project if database schema changes.

