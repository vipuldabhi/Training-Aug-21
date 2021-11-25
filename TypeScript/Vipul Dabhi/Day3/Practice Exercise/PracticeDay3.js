// Generic
function identity(arg) {
    return arg;
}
var output1 = identity("myString");
var output2 = identity(100);
console.log(output1);
console.log(output2);
// Multi-type variables
function displayDataType(id, name) {
    console.log("DataType of Id: " + typeof (id) + "\nDataType of Name: " + typeof (name));
}
displayDataType(101, "Abhishek");
//   Generic with non-generic Type
// function displayDataType<T>(id:T, name:string): void {   
//     console.log("DataType of Id: "+typeof(id) + "\nDataType of Name: "+ typeof(name));    
//   }  
//   displayDataType<number>(1, "Abhishek");  
//   Generics Classes
var StudentInfo = /** @class */ (function () {
    function StudentInfo() {
    }
    StudentInfo.prototype.setValue = function (id, name) {
        this.Id = id;
        this.Name = name;
    };
    StudentInfo.prototype.display = function () {
        console.log("Id = ".concat(this.Id, ", Name = ").concat(this.Name));
    };
    return StudentInfo;
}());
var st = new StudentInfo();
st.setValue(101, "Virat");
st.display();
var std = new StudentInfo();
std.setValue("201", "Rohit");
std.display();
// namespace
/// <reference path="namespaces.ts" />
var data = employee.salary.DisplaySalary(23);
console.log(data);
var display = employee.displayDataType(2323);
