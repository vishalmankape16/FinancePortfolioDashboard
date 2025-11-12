# FinancePortfolioDashboard
<img width="1920" height="1080" alt="Screenshot (181)" src="https://github.com/user-attachments/assets/b15cf37b-819a-42b3-bcf6-82aca7a5fde3" />
<img width="1920" height="1080" alt="Screenshot (179)" src="https://github.com/user-attachments/assets/edb6f2d8-249b-4f4b-9528-09f6fd8065ae" />
<img width="1920" height="1080" alt="Screenshot (180)" src="https://github.com/user-attachments/assets/a7f395e6-0292-4af2-bba3-8757af96a6e4" />

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
