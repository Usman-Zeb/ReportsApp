# DevExpress Report App

This application demonstrates how to integrate DevExpress Reporting with ASP.NET Core to display reports using the Web Document Viewer.

## Table of Contents
- Introduction
- Setup
- Database
- Reports
- Usage
- License

## Introduction

This application showcases the integration of DevExpress Reporting tools in an ASP.NET Core environment. It includes sample reports that fetch data from a local MSSQL database and display it using the Web Document Viewer.

## Setup

To run this application locally:

1. Clone the repository:
   git clone https://github.com/Usman-Zeb/ReportsApp.git
   cd ReportsApp

2. Restore NuGet packages and build the project:
   dotnet restore
   dotnet build

3. Configure your local MSSQL database:
   - Create a database named `DevExpressDemo`.
   - Execute the following SQL scripts to create tables (`Orders` and `Products`) and populate them with sample data:

```sql
   CREATE DATABASE DevExpressDemo;
   USE DevExpressDemo;

   CREATE TABLE Orders (
       OrderId INT PRIMARY KEY,
       OrderNumber NVARCHAR(50)
   );

   CREATE TABLE Products (
       ProductId INT PRIMARY KEY,
       ProductName NVARCHAR(100),
       Price DECIMAL(8,2),
       OrderId INT,
       FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
   );

   INSERT INTO Orders (OrderId, OrderNumber)
   VALUES 
       (101, 'ORD1001'),
       (102, 'ORD1002'),
       (103, 'ORD1003'),
       (104, 'ORD1004'),
       (105, 'ORD1005'),
       (106, 'ORD1006'),
       (107, 'ORD1007'),
       (108, 'ORD1008'),
       (109, 'ORD1009'),
       (110, 'ORD1010');

   INSERT INTO Products (ProductId, ProductName, Price, OrderId)
   VALUES
       (201, 'Laptop', 999.99, 101),
       (202, 'Mouse', 19.99, 101),
       (203, 'Keyboard', 49.99, 102),
       (204, 'Monitor', 199.99, 102),
       (205, 'Printer', 129.99, 103),
       (206, 'Desk Chair', 89.99, 103),
       (207, 'Desk Lamp', 29.99, 104),
       (208, 'Notebook', 2.99, 104),
       (209, 'Pen', 1.49, 105),
       (210, 'Pencil', 0.99, 105),
       (211, 'Tablet', 299.99, 106),
       (212, 'Smartphone', 499.99, 106),
       (213, 'Headphones', 59.99, 107),
       (214, 'Webcam', 39.99, 107),
       (215, 'External Hard Drive', 79.99, 108),
       (216, 'USB Flash Drive', 9.99, 108),
       (217, 'Router', 49.99, 109),
       (218, 'Switch', 39.99, 109),
       (219, 'Scanner', 99.99, 110),
       (220, 'Projector', 499.99, 110);

```

## Database

The application uses a local MSSQL database named `DevExpressDemo` with two tables: `Orders` and `Products`.

## Reports

The reports are designed using DevExpress Reporting tools and are displayed using the Web Document Viewer.

## Usage

To use this application:

1. Ensure you have configured the local MSSQL database as described in the Setup section.
2. Run the application.
3. Navigate to the `Viewer` page to view the reports generated based on the database data.

## License

This project is licensed under the [MIT License](LICENSE).

---
