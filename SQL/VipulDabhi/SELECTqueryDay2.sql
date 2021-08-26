SELECT * FROM Employees;
SELECT FirstName , LastName FROM Employees;
SELECT firstName AS 'Employee Name' FROM Employees;
SELECT * FROM Employees WHERE FirstName = 'Steven';
SELECT * FROM Employees WHERE FirstName IN ('Neena','Lex');
SELECT * FROM Employees WHERE FirstName != 'Neena';
SELECT * FROM Employees WHERE Salary BETWEEN '5000' AND '8000';
SELECT FirstName,LastName,Salary,Salary*.12 AS PF FROM Employees;
SELECT * FROM Employees WHERE FirstName LIKE 'N%';
SELECT DISTINCT DepartmentID FROM Employees;
SELECT * FROM Employees ORDER BY FirstName DESC;
SELECT EmployeeID,FirstName,LastName,Salary FROM Employees ORDER BY Salary ASC;
SELECT TOP 2 Salary FROM Employees;


