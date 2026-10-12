# DEPI MVC & EF Core Assignment

An ASP.NET Core MVC application developed as part of the Digital Egypt Pioneers Initiative (DEPI), using Entity Framework Core 8 and SQL Server.

## 📌 Project Overview

This project demonstrates the implementation of an MVC application with Entity Framework Core, relational database modeling, and student data management.

It provides two main pages for displaying all students and viewing the details of a specific student.

## 🚀 Features

* **Student List:** Display all students with their IDs, names, ages, and department names.
* **Student Details:** View detailed information about a specific student using their ID.
* **Entity Framework Core 8:** Manage database operations using EF Core.
* **SQL Server Integration:** Store and retrieve data from a relational database.
* **Code-First Migrations:** Create and update the database schema using EF Core migrations.
* **MVC Architecture:** Separate application logic, data models, and presentation views.

## 🛠️ Technologies Used

* C#
* ASP.NET Core MVC (.NET 8)
* Entity Framework Core 8
* SQL Server
* Razor Views
* Bootstrap

## 📂 Project Structure

```text
DEPI-MVC-EFCore-Assignment/
│
├── Controllers/
│   └── StudentController.cs
│
├── Data/
│   └── SchoolDbContext.cs
│
├── Models/
│   ├── Department.cs
│   ├── Student.cs
│   ├── Course.cs
│   ├── Teacher.cs
│   └── StuCrsRes.cs
│
├── Views/
│   └── Student/
│       ├── ShowAll.cshtml
│       └── ShowDetails.cshtml
│
├── Migrations/
├── appsettings.json
├── Program.cs
└── README.md
```

*Note: The structure above highlights the main project files. Actual filenames and folders may vary slightly.*

## 🌐 Application Pages

### 1. Show All Students

**Route:**

```text
/Student/ShowAll
```

Displays a table containing all students and their department names, with a link to view each student's details.

### 2. Show Student Details

**Route:**

```text
/Student/ShowDetails?id=3
```

Displays the selected student's ID, name, age, and department.

Replace `3` with the ID of the student you want to view.

## 🗄️ Database Models

The application includes the following entities:

| Entity     | Description                                                        |
| ---------- | ------------------------------------------------------------------ |
| Department | Stores department information.                                     |
| Student    | Stores student information and department relationships.           |
| Course     | Stores course information and department relationships.            |
| Teacher    | Stores teacher information and related course and department data. |
| StuCrsRes  | Represents student-course relationships and stores grades.         |

The `StuCrsRes` entity uses a composite primary key consisting of `StudentId` and `CourseId`.

## ⚙️ Getting Started

### Prerequisites

Make sure you have the following installed:

* .NET 8 SDK
* SQL Server
* Visual Studio 2022 or another compatible .NET IDE

### 1. Clone the Repository

```bash
git clone https://github.com/mohamedfouadhamedhelail/DEPI-MVC-EFCore-Assignment.git
```

### 2. Navigate to the Project Directory

```bash
cd DEPI-MVC-EFCore-Assignment
```

### 3. Configure the Database Connection

Update the connection string in `appsettings.json` to match your SQL Server configuration.

### 4. Apply Database Migrations

Open the terminal in the directory containing the project file and run:

```bash
dotnet ef database update
```

If the EF Core CLI tool is not installed, install it using:

```bash
dotnet tool install --global dotnet-ef
```

### 5. Run the Application

```bash
dotnet run
```

Open the local URL displayed in the terminal, then navigate to:

```text
/Student/ShowAll
```

## 🎯 Learning Objectives

Through this assignment, I practiced:

* Implementing the MVC architectural pattern.
* Configuring Entity Framework Core 8.
* Defining entities and relationships.
* Working with SQL Server and Code-First migrations.
* Retrieving related data using `Include()`.
* Passing model data from controllers to Razor views.
* Implementing routes that accept query-string parameters.

## 👨‍💻 Author

**Mohamed Fouad**

* GitHub: [mohamedfouadhamedhelail](https://github.com/mohamedfouadhamedhelail)
* LinkedIn: [Mohamed Fouad](https://www.linkedin.com/in/mohamed-fouad-95a1ba383/)

---

Developed as part of the **Digital Egypt Pioneers Initiative (DEPI)**.
