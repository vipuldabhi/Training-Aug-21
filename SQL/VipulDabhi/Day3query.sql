--01
SELECT 'First Name' = FirstName,'Name Length' = LEN(FirstName) 
FROM Employees WHERE FirstName LIKE 'A%' OR FirstName LIKE 'J' OR FirstName LIKE 'M%'  ORDER BY FirstName;

--02
SELECT firstname,'SALARY' = RIGHT(REPLICATE('$',10-LEN(Salary)) + 
CAST(Salary AS VARCHAR),10) 
from Employees

--03
SELECT EmployeeID,FirstName,LastName,HireDate FROM Employees WHERE DATEPART(DD,HireDate)=07
OR DATEPART(MM,HireDate)=07 ORDER BY HireDate

--04
SELECT LEN(FirstName) FROM EMPLOYEES WHERE FirstName LIKE '__c%';


--05
SELECT RIGHT (PhoneNumber,4) FROM Employees;

--06
UPDATE Employees SET PhoneNumber = REPLACE(PhoneNumber,'124','999');


--07
SELECT DATEDIFF(yyyy,'2000-12-01',GETDATE());


--08
SELECT HireDate FROM Employees WHERE DATENAME(DW,HireDate) = 'MONDAY';


--09
SELECT FirstName, HireDate FROM Employees WHERE HireDate BETWEEN '1987-06-01 00:00:00' AND '1987-07-30 00:00:00';


--10
SELECT 'Current Date' = FORMAT( GETDATE(),'hh:mm tt MMMM dd,yyyy' );


--11
SELECT FirstName, LastName FROM Employees WHERE DATENAME(MM,HireDate) = 'june' ;


--12
SELECT FirstName,HireDate,DATEDIFF(YY,HireDate,GETDATE()) AS Expirences FROM Employees;

--13
SELECT FirstName, HireDate FROM Employees WHERE YEAR(HireDate)=1987;