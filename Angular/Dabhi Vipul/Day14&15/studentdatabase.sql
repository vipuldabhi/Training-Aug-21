create database StudentDatabase
use StudentDatabase

CREATE TABLE Student(
	StudentId INT PRIMARY KEY IDENTITY(1,1),
	firstname VARCHAR(50),
	middlename VARCHAR(50),
	lastname VARCHAR(50),
	dateofbirth DateTime,
	placeofbirth VARCHAR(50),
	firstlanguage VARCHAR(50),
	city VARCHAR(50),
	state VARCHAR(30),
	country VARCHAR(30),
	pin INT,
	fatherfirstname VARCHAR(50),
	fathermiddlename VARCHAR(50),
	fatherlastname VARCHAR(50),
	fatheremail VARCHAR(50),
	fatherqualification VARCHAR(50),
	fatherprofession VARCHAR(50),
	fatherdesignation VARCHAR(50),
	fatherphone VARCHAR(50),
	motherfirstname VARCHAR(50),
	mothermiddlename VARCHAR(50),
	motherlastname VARCHAR(50),
	motheremail VARCHAR(50),
	motherqualification VARCHAR(50),
	motherprofession VARCHAR(50),
	motherdesignation VARCHAR(50),
	motherphone VARCHAR(50),
	refdetails VARCHAR(50),
	refthrough VARCHAR(50),
	refaddress VARCHAR(50)
) 
--drop table Emergency
CREATE TABLE Emergency(
	Id INT PRIMARY KEY IDENTITY(1,1),
	relation VARCHAR(50),
	phone VARCHAR(50),
	StudentId INT FOREIGN KEY REFERENCES Student(StudentId) ON DELETE CASCADE,
)
select * from Emergency