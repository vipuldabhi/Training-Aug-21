SELECT * FROM Employees
SELECT EmployeeID, Salary,RANK() OVER (ORDER BY Salary ASC) FROM Employees;
SELECT * FROM (SELECT *,DENSE_RANK() OVER ( ORDER BY Salary DESC ) 'SalaryRank' FROM Employees ) TEMP WHERE SalaryRank = '4'
SELECT DepartmentID,SUM(Salary) FROM Employees GROUP BY DepartmentID
SELECT DepartmentID,SUM(Salary) FROM Employees GROUP BY DepartmentID ORDER BY SUM(Salary) DESC 
SELECT DepartmentID,MAX(Salary) FROM Employees GROUP BY DepartmentID ORDER BY MAX(Salary)
SELECT DepartmentID,MIN(Salary) FROM Employees GROUP BY DepartmentID ORDER BY MIN(Salary)
SELECT DepartmentID,SUM(Salary) FROM Employees GROUP BY DepartmentID HAVING SUM(Salary) >= 50000 ORDER BY SUM(Salary) DESC



