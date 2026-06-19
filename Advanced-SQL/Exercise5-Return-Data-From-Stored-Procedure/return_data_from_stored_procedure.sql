CREATE PROCEDURE GetEmployees
AS
BEGIN
    SELECT EmployeeID, EmployeeName, Salary
    FROM Employees;
END;

EXEC GetEmployees;
