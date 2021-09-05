
--STRING FUNCTIONS

SELECT ASCII('c');
SELECT CHAR(68)
SELECT CHARINDEX('Available',Email) FROM employees
SELECT CONCAT(FirstName,LastName) FROM Employees
SELECT FORMAT(090909,'##-###-#') 
SELECT LEFT(FirstName,2) FROM Employees
SELECT RIGHT(LastName,3) FROM Employees
SELECT LEN(FirstName) FROM Employees
SELECT LOWER(FirstName) FROM Employees
SELECT LTRIM('     JOHN SMITH')
SELECT RTRIM('JOHN SMITH       ')
SELECT PATINDEX('%vail%',Email) FROM Employees
SELECT REPLACE(Email,'Not','Soon') FROM Employees
SELECT REPLICATE(FirstName,2) FROM Employees
SELECT REVERSE(FirstName) FROM Employees
SELECT SOUNDEX(FirstName) FROM Employees
SELECT STR(12.233243434,5,5)
SELECT STUFF(PhoneNumber,3,3,'111') FROM Employees
SELECT SUBSTRING(FirstName,2,4) FROM Employees
SELECT TRANSLATE('FirstName','First','Last_')
SELECT TRIM('.!,' FROM '.    JOHN             !,')
SELECT UNICODE(FirstName) FROM Employees


--DateTime Function

SELECT CURRENT_TIMESTAMP;
SELECT DATEADD(MM,4,HireDate) FROM Employees;
SELECT DATEDIFF(MM,HireDate,GETDATE()) FROM Employees;
SELECT DATENAME(MM,HireDate)  FROM Employees;
SELECT DATEPART(MM,HireDate) FROM Employees;
SELECT DAY(HireDate) FROM Employees;
SELECT GETDATE();
SELECT GETUTCDATE() AS CoordinatedUniversalTime;
SELECT ISDATE('2000-02-15') AS CheckDateIsValidOrNot;
SELECT MONTH(HireDate) FROM Employees;
SELECT SYSDATETIME() AS SystemDateTime;
SELECT SYSDATETIMEOFFSET() AS WithTimeZoneOffset;
SELECT SYSUTCDATETIME() AS SystemUtcDateTime;
SELECT YEAR(HireDate) FROM Employees;


--Maths Function--

SELECT CEILING(19.87);
SELECT EXP(4.5) AS ExponentialValue;
SELECT FLOOR(23.67);
SELECT POWER(2,3);
SELECT ROUND(34.5789,2);

--System Function--

--Returns the error number for the last Transact-SQL statement executed.
SELECT @@ERROR
--Is a system function that returns the last-inserted identity value.
SELECT @@IDENTITY
--Returns the number of input packets read from the network by SQL Server since it was last started
SELECT @@PACK_RECEIVED
--Returns the number of rows affected by the last statement. 
SELECT @@ROWCOUNT
--Returns the number of BEGIN TRANSACTION statements that have occurred on the current connection.
SELECT @@TRANCOUNT
--For a request that comes in to the server, this function returns information about the connection properties of the unique connection which supports that request.
--!SELECT CONNECTIONPROPERTY(Property);
--For exact information about the current request, use CURRENT_REQUEST_ID().
SELECT CURRENT_REQUEST_ID();
--This function returns the transaction ID of the current transaction in the current session
SELECT CURRENT_TRANSACTION_ID();
--Returns the workstation identification number. The workstation identification number is the process ID (PID) of the application on the client computer that is connecting to SQL Server.
SELECT HOST_ID()
--Returns the workstation name.
SELECT HOST_NAME()
SELECT ISNULL(firstname,'JohnSmith') FROM Employees;
SELECT ISNUMERIC(Salary) FROM Employees;
--The following example uses NEWID() to assign a value to a variable declared as the uniqueidentifier data type.
SELECT NEWID();
SELECT ROWCOUNT_BIG()--Return type is big integer









