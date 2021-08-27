--!**!Assignment Query!**!

CREATE TABLE SalesPerson(
			EmployeeId INT NOT NULL PRIMARY KEY,
			EmployeeName VARCHAR(100),
			Commission INT NOT NULL);
CREATE TABLE CarsDetails(
			ModelId INT NOT NULL PRIMARY KEY,
            EmployeeId INT NOT NULL,
            Price INT NOT NULL ,
			FOREIGN KEY(EmployeeId) REFERENCES SalesPerson(EmployeeId));
			
CREATE TABLE Total_sales( 
		 	 ModelId INT NOT NULL,
             Price INT NOT NULL,
			 Sold INT NOT NULL,
			 FOREIGN KEY(Sold) REFERENCES SalesPerson(EmployeeId),
			 FOREIGN KEY(ModelId)REFERENCES CarsDetails(ModelId));
