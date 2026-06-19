CREATE TABLE Employees (
    EmployeeID INT,
    EmployeeName VARCHAR(50),
    Salary INT
);
INSERT INTO Employees VALUES
(1, 'John', 50000),
(2, 'Alice', 70000),
(3, 'Bob', 60000),
(4, 'David', 70000);

SELECT
    EmployeeName,
    Salary,
    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNum,
    RANK() OVER (ORDER BY Salary DESC) AS RankNum,
    DENSE_RANK() OVER (ORDER BY Salary DESC) AS DenseRankNum
FROM Employees;
