CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    Department VARCHAR(50)
);

CREATE INDEX IX_EmployeeName
ON Employees(EmployeeName);

SELECT * FROM Employees
WHERE EmployeeName = 'John';
