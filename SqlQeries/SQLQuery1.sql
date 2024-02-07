
-- Database oluþturma (DDL)
CREATE DATABASE SampleDB;

-- Tablo oluþturma (DDL)
USE SampleDB;

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Department NVARCHAR(50),
    Salary DECIMAL(10, 2)
);

-- Veri ekleme (DML)
INSERT INTO Employees (EmployeeID, FirstName, LastName, Department, Salary) 
VALUES (1, 'Merve', 'Saruhan', 'Master Planning', 55000.00);

INSERT INTO Employees (EmployeeID, FirstName, LastName, Department, Salary) 
VALUES (2, 'Hasan', 'Bozkurt', 'Finance', 45000.00);

-- Veri güncelleme (DML)
UPDATE Employees SET Salary = 65000.00 WHERE EmployeeID = 1;

-- Veri silme (DML)
DELETE FROM Employees WHERE EmployeeID = 2;

-- Tablo güncelleme (DDL)
ALTER TABLE Employees ADD Email NVARCHAR(100);

-- Tablo silme (DDL)
DROP TABLE Employees;

-- Database silme (DDL)
USE master;
DROP DATABASE SampleDB;



