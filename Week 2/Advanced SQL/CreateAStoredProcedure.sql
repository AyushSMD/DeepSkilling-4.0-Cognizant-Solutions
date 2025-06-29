DROP PROCEDURE IF EXISTS sp_InsertEmployee

CREATE PROCEDURE sp_InsertEmployee (
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (p_FirstName, p_LastName, p_DepartmentID, p_Salary, p_JoinDate);
END;

CALL sp_InsertEmployee('Alice', 'Walker', 2, 6200.00, '2022-05-01');

SELECT * FROM employees

DROP PROCEDURE IF EXISTS sp_GetEmployeesByDepartment

CREATE PROCEDURE sp_GetEmployeesByDepartment (
    IN p_DepartmentID INT
)
BEGIN
    SELECT EmployeeID, FirstName, LastName, Salary, JoinDate
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END;

CALL sp_GetEmployeesByDepartment(2);
