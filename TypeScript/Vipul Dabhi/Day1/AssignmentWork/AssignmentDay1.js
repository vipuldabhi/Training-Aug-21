var employees = [{ "Id": 0, "FirstName": "Mehul", "LastName": "Shah", "Address": { "FlatNumber": 23, "City": "Ahmedabad", "State": "Gujarat" }, "Salary": 50000 },
    { "Id": 1, "FirstName": "Neena", "LastName": "Patel", "Address": { "FlatNumber": 4, "City": "Bharuch", "State": "Gujarat" }, "Salary": 30000 },
    { "Id": 2, "FirstName": "Nayan", "LastName": "Dave", "Address": { "FlatNumber": 15, "City": "Mumbai", "State": "Maharastra" }, "Salary": 20000 },
    { "Id": 3, "FirstName": "Mahesh", "LastName": "Patel", "Address": { "FlatNumber": 246, "City": "Katch", "State": "Gujarat" }, "Salary": 50000 },
    { "Id": 4, "FirstName": "Rahul", "LastName": "Shah", "Address": { "FlatNumber": 2, "City": "Rajkot", "State": "Gujarat" }, "Salary": 70000 }];
// // Searching By IndexNumber
// var employeeByIndexNo = employees[2];
// console.log(employeeByIndexNo);
// // Searching By EmployeeID
// var employeeByEmpID = employees.filter(i => i.Id === 4);
// console.log(employeeByEmpID);
// // Insert Employee Data In Employee Array
// var insertemployee = {"Id":5,"FirstName":"Sneh","LastName":"Sharma","Address":{"FlatNumber":22,"City":"Botad","State":"Gujarat"},"Salary":50000};
// employees.push(insertemployee);
// // Delete Employee From Array
// // delete last element of array
// var popedEmployee = employees.pop();
// console.log(popedEmployee);
// // delete first element of array
// var shiftedEmployee = employees.shift()
// console.log(shiftedEmployee);
// Create Another Employee Array
//  var employees1 : {Id:number,FirstName:string,LastName:string,Address:{FlatNumber:number,City:string,State:string},Salary:number}[] = 
//                 [
//                     {"Id":6,"FirstName":"Shrdha","LastName":"Anupam","Address":{"FlatNumber":1,"City":"Ahmedabad","State":"Maharastra"},"Salary":20000},
//                     {"Id":7,"FirstName":"Neha","LastName":"Oshwal","Address":{"FlatNumber":8,"City":"Rajkot","State":"Gujarat"},"Salary":50000}
//                 ];
// employees = employees.concat(employees1);
// for(var i of employees)
// {
//     console.log(`ID is ${i.Id} Name is ${i.FirstName + i.LastName} Address is ${i.Address} Salary is ${i.Salary}.`);
// }
// Dispaly Employees
for (var _i = 0, employees_1 = employees; _i < employees_1.length; _i++) {
    var i = employees_1[_i];
    console.log("ID : ".concat(i.Id, ", Name : ").concat(i.FirstName + i.LastName, ", Address : FlatNumber is ").concat(i.Address.FlatNumber, " \n                City is ").concat(i.Address.City, " State is ").concat(i.Address.State, ", Total Salary : ").concat((i.Salary) - ((i.Salary) * (0.12)), "."));
}
