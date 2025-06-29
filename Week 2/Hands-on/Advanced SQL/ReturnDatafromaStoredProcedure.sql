DROP PROCEDURE IF EXISTS sp_GetNoOfEmployeesInDepartment;

CREATE PROCEDURE sp_GetNoOfEmployeesInDepartment (
    IN p_DepartmentID INT
)
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END;

