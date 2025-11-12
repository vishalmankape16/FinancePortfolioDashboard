# FinancePortfolioDashboard

![.NET](https://img.shields.io/badge/.NET-9-blue)
![C#](https://img.shields.io/badge/C%23-9.0-blue)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-green)
![License](https://img.shields.io/badge/License-MIT-lightgrey)

## Project Overview

**FinancePortfolioDashboard** is an ASP.NET Core MVC web application that allows users to **manage, track, and visualize their financial portfolios**. Built with C# and Entity Framework Core, the app provides a clean dashboard for portfolios, detailed asset tracking, and database-driven CRUD operations.

This project is ideal for developers learning MVC, database integration, and real-world financial data management.

---

## Features

- **Portfolio Management**
  - Create, edit, and delete portfolios
  - Each portfolio has Name, Description, Category, and Risk Level
- **Asset Tracking**
  - Add assets to portfolios (stocks, bonds, other investments)
  - Track quantity, purchase price, and current value
- **Dashboard**
  - Quick overview of all portfolios
  - Portfolio summaries and risk level alerts
- **Database Integration**
  - SQL Server backend with Entity Framework Core
  - Supports full CRUD operations

---

## Technologies Used

- **Backend:** C#, .NET 9 MVC
- **Frontend:** Razor Pages (HTML, CSS, Bootstrap optional)
- **Database:** SQL Server / SQL Server Express
- **ORM:** Entity Framework Core
- **Version Control:** Git & GitHub

---

## Installation & Setup

1. Clone the repository:

```bash
git clone https://github.com/vishalmankape16/FinancePortfolioDashboard.git
cd FinancePortfolioDashboard
Open the project in Visual Studio 2022 or later.

Ensure you have SQL Server Express installed.

Update the appsettings.json connection string to match your SQL Server instance:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=FinancePortfolioDB;Trusted_Connection=True;TrustServerCertificate=True;"
}


Restore NuGet packages:

dotnet restore


Apply migrations to create the database:

dotnet ef database update


Run the application:

dotnet run


Open your browser and navigate to:

https://localhost:5001
