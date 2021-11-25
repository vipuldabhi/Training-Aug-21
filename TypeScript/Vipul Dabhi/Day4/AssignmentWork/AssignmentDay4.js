var Employees = [{ ID: 1, Name: "Mahesh", City: "Ahmedabad", DOJ: new Date(2020 / 2 / 12) },
    { ID: 2, Name: "Neha", City: "Surat", DOJ: new Date(2012 / 2 / 23) },
    { ID: 3, Name: "Sheetal", City: "Porbandar", DOJ: new Date(2021 / 2 / 23) },
    { ID: 4, Name: "Jayesh", City: "Rajkot", DOJ: new Date(2000 / 5 / 2) },
    { ID: 5, Name: "Neena", City: "Mumbai", DOJ: new Date("2022/1/12") }];
console.log("Enter Id Of employee");
var id = 1;
for (var _i = 0, Employees_1 = Employees; _i < Employees_1.length; _i++) {
    var x = Employees_1[_i];
    if (x.ID === id) {
        console.log("Id : ".concat(x.ID, ",Name : ").concat(x.Name, ",City : ").concat(x.City, ",DateOfJoining : ").concat(x.DOJ));
    }
}
// Search the employees who has joined after year 2020
for (var _a = 0, Employees_2 = Employees; _a < Employees_2.length; _a++) {
    var i = Employees_2[_a];
    if (i.DOJ.getFullYear() > 2020) {
        console.log("Id : ".concat(i.ID, ",Name : ").concat(i.Name, ",City : ").concat(i.City, ",DateOfJoining : ").concat(i.DOJ));
    }
}
// Search the employee who has joined after year 2020 and stays in Mumbai city
var FilterEmp = Employees.filter(function (i) { return i.DOJ.getFullYear() > 2020 && i.City === "Mumbai"; });
for (var _b = 0, FilterEmp_1 = FilterEmp; _b < FilterEmp_1.length; _b++) {
    var j = FilterEmp_1[_b];
    console.log("Id : ".concat(j.ID, ",Name : ").concat(j.Name, ",City : ").concat(j.City, ",DateOfJoining : ").concat(j.DOJ));
}
