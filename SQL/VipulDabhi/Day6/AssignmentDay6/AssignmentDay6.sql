SELECT * FROM Employee;
SELECT * FROM Incentives;

--Select employee details from employee table if data exists in incentive table ?
SELECT * FROM Employee WHERE EmployeeID IN (SELECT Employee_Ref_Id FROM Incentives);

--Find Salary of the employee whose salary is more than Roy Salary
SELECT Salary FROM employee WHERE Salary > (SELECT Salary FROM Employee WHERE FirstName = 'Roy') ;

--Create a view to select FirstName,LastName,Salary,JoiningDate,IncentiveDate and IncentiveAmount
CREATE VIEW ABC 
AS 
SELECT E.FirstName,E.Lastname,E.Salary,E.JoiningDate,I.Incentive_Date,I.Incentive_Amount FROM 
Employee E JOIN Incentives I ON E.EmployeeID = I.Employee_Ref_Id;

--Create a view to select Select first_name, incentive amount from employee and incentives table for those employees who have incentives and incentive amount greater than 3000
CREATE VIEW DEMO 
AS 
SELECT E.FirstName,I.Incentive_Amount FROM Employee E JOIN Incentives I ON E.EmployeeID = I.Employee_Ref_Id
WHERE Incentive_Amount > 3000;

SELECT * FROM DEMO
SELECT * FROM ABC
SELECT * FROM Locations
SELECT * FROM Departments
SELECT * FROM Employees
SELECT * FROM JobHistory

--Create a View to Find the names (first_name, last_name), job, department number, and department name of the employees who work in London
CREATE VIEW DEMO2 
AS 
SELECT E.FirstName+ ' ' +E.LastName AS Name ,E.jobid,D.DepartmentID,D.DepartmentName 
FROM Employees E JOIN Departments D ON E.departmentID = D.DepartmentID JOIN Locations L 
ON D.LocationID = L.LocationID WHERE City = 'London'

--Create a View to get the department name and number of employees in the department.
CREATE VIEW DEMO3 
AS
SELECT D.DepartmentName,D.DepartmentID FROM Departments D

--Find the employee ID, job title, number of days between ending date and starting date for all jobs in department 90 from job history.
SELECT E.EmployeeID,E.JobId,DATEDIFF(DD,StartDate,EndDate) FROM Employees E JOIN JobHistory J ON E.EmployeeID = J.EmployeeID

--Write a View to display the department name, manager name, and city.
CREATE VIEW DEMO4
AS
SELECT D.Departmentname,E.FirstName AS ManagerName,L.City FROM Employees E JOIN Departments D ON E.EmployeeID = D.DepartmentID JOIN Locations L ON D.LocationID = L.LocationID

--Create a View to display department name, name (first_name, last_name), hire date, salary of the manager for all managers whose experience is more than 15 years.
CREATE VIEW DEMO5
AS
SELECT D.DepartmentName,E.FirstName+ ' ' +E.LastName AS Name ,E.HireDate,E.Salary,DATEDIFF(YY,HireDate,GETDATE()) FROM Employees E JOIN Departments D ON E.EmployeeID = D.DepartmentID WHERE DATEDIFF(YY,HireDate,GETDATE()) > 15


