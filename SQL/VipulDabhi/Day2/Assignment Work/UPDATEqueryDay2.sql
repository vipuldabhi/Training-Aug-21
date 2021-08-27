UPDATE Employees SET Email = 'not available'; 
SELECT * FROM Employees;
SELECT * FROM Departments
UPDATE Employees SET CommissionPct = '0.10'
UPDATE Employees SET Email = 'not available' , CommissionPct = '0.10' WHERE DepartmentID = '110';
UPDATE Employees SET Email = 'not available' WHERE DepartmentID = '80' AND CommissionPct <= 0.20;
UPDATE Employees SET Email = 'not available' WHERE DepartmentID = (SELECT DepartmentID FROM Departments WHERE DepartmentName = 'Accounting');
UPDATE Employees SET Salary = '8000' WHERE EmployeeID = '105' AND Salary <= '5000';
UPDATE Employees SET JobId = 'SH_CLERK' WHERE EmployeeID = '118' AND DepartmentID = '30' AND JobId NOT LIKE 'SH%';
UPDATE Employees SET Salary  = CASE DepartmentID
								WHEN 40 THEN Salary +( Salary *.25)
								WHEN 90 THEN Salary + (Salary *.15)
								WHEN 110 THEN Salary + (Salary *.10)
								ELSE Salary END


								
