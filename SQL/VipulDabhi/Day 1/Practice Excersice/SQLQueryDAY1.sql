CREATE TABLE Country
(
CountryId INT PRIMARY KEY,
CountryName varchar(100) CHECK(CountryName IN('Italy','India','China')), 
RegionId INT UNIQUE,
CONSTRAINT CidnotRid CHECK (CountryId != RegionID),

)
SELECT * FROM Country


CREATE TABLE JobHistory
(
EmployeeId INT PRIMARY KEY,
StartDate DateTime,
End_Date DateTime,
Job_ID INT,
Depatment_Id INT,
)
SELECT * FROM JobHistory

CREATE TABLE jobs
(
JobId INT,
JobTitle VARCHAR(100) DEFAULT NULL,
MinSalary INT CHECK (MinSalary >= 8000),
MaxSalary INT DEFAULT NULL,
PRIMARY KEY (JobId)
)
SELECT * FROM jobs

CREATE TABLE Employees
(
employeeId INT UNIQUE,
FirstName VARCHAR(100),
LastName VARCHAR(100),
Email VARCHAR(100),
PhoneNumber INT,
Hire_Date DATETIME,
Job_Id INT,
Salary INT,
Commission INT,
manager_Id INT,
Department_Id INT PRIMARY KEY,
FOREIGN KEY (Job_Id) REFERENCES jobs(JobId),
FOREIGN KEY (Department_Id) REFERENCES Department(DepartmentId),
)
CREATE TABLE Department 
(
DepartmentId INT
PRIMARY KEY (DepartmentId)
)
SELECT * FROM Department


ALTER TABLE JobHistory
ADD CONSTRAINT fk_job_id FOREIGN KEY (Job_ID) REFERENCES jobs(JobId)

ALTER TABLE JobHistory
DROP CONSTRAINT 

ALTER TABLE JobHistory
ADD location_ VARCHAR(100)

