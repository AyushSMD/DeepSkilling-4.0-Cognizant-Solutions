-- SELECT * FROM Departments;
-- SELECT * FROM Employees;

-- Create database and use it
CREATE DATABASE IF NOT EXISTS EMS;
USE EMS;

-- Drop tables if they exist
DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;

-- Create Departments table
CREATE TABLE Departments (
  DepartmentID INT PRIMARY KEY,
  DepartmentName VARCHAR(100)
);

-- Create Employees table with proper foreign key
CREATE TABLE Employees (
  EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
  FirstName VARCHAR(50),
  LastName VARCHAR(50),
  DepartmentID INT,
  Salary DECIMAL(10,2),
  JoinDate DATE,
  FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- Insert into Departments
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

-- Insert into Employees
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');

-- View data
SELECT * FROM Departments;
SELECT * FROM Employees;
