CREATE FUNCTION GetAnnualSalary
(
    @MonthlySalary INT
)
RETURNS INT
AS
BEGIN
    RETURN @MonthlySalary * 12;
END;
GO

SELECT dbo.GetAnnualSalary(5000) AS AnnualSalary;
