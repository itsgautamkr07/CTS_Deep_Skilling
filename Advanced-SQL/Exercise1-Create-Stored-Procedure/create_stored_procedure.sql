CREATE PROCEDURE GetEmployeeDetails
AS
BEGIN
    SELECT EmployeeID, EmployeeName, Salary
    FROM Employees;
END;
