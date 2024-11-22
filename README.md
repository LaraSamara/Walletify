# Walletify
## Overview

**Walletify** is a financial management web application built using ASP.NET Core. It allows users to track their savings, set financial goals, and manage transactions effectively. The application leverages the Model-View-Controller (MVC) pattern and integrates with Identity for user management and authentication. 

## Table of Contents

- [Features](#features)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Database Setup](#database-setup)
- [Running the Application](#running-the-application)
- [License](#license)

## Features  
- **User Management:**  
  - Registration, login, and secure authentication.  
  - User profile management.  

- **Expense Tracking:**  
  - Add, view, and categorize expenses.  
  - Generate detailed expense reports.  

- **User-Friendly Interface:**  
  - Intuitive design for seamless navigation.  
  - Enhanced user experience with responsive layouts.  

- **Flexible Codebase:**  
  - Implemented the **Factory Design Pattern** for better code flexibility and maintainability.  

- **Advanced Functionality:**  
  - Integrated **job scheduling** for automating recurring tasks.  
  - Third-party **email messaging services** for sending notifications and updates.  

---

## Project Structure

The project structure is organized as follows:
```
Walletify/
├── .vs/                  # Visual Studio configuration files
├── DB_Design/            # Database design documents
├── Walletify/            # Main application directory
│   ├── ApplicationDbContext/  # Entity Framework DB context
│   ├── Controllers/      # ASP.NET Core MVC controllers
│   ├── DependencyInjection/  # Custom dependency injection classes
│   ├── Migrations/       # Entity Framework migrations
│   ├── Models/           # Entity models for database
│   ├── Repositories/     # Data access layer
│   ├── ViewModel/        # View models for data binding in views
│   ├── Views/            # Razor views (UI)
│   └── wwwroot/          # Static files (CSS, JavaScript, Images)
```
## Technologies Used

- **Framework**: ASP.NET Core 8.0
- **Frontend**: Razor Views, Bootstrap, jQuery
- **Database**: Entity Framework Core with SQL Server
- **Authentication**: ASP.NET Identity
- **Dependency Injection**: Custom service registration for repositories
- **Version Control**: Git

## Installation

### Prerequisites

Ensure you have the following installed:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) with ASP.NET and web development workloads

### Steps

1. **Clone the repository:**

   ```bash
   git clone https://github.com/ahmadhamarsheh/Walletify.git
   cd walletify/Walletify
	 ```
2. **Install dependencies:**
    
    Run the following command to restore the required NuGet packages:
    
    ```jsx
    dotnet restore
    
    ```

## Database Setup

1. **Configure the connection string**:
Open `appsettings.json` in the `Walletify` project and update the connection string for your SQL Server instance:
    
    ```jsx
    "ConnectionStrings": {
      "DefaultConnection": "Server=your_server;Database=WalletifyDB;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```
    
2. **Apply Migrations**:
Use the following command to apply the Entity Framework migrations and set up the database:
    
    ```jsx
    add-migration nameOfMigrate
    update-database
    ```

## Running the Application

1. **Build the project**:
    
    ```jsx
    dotnet build
    ```
    
2. **Run the application**:
    
    ```jsx
    dotnet run
    ```
    
3. Open your browser and navigate to `http://localhost:5000`.

##  License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

