// namespace
var employee;
(function (employee) {
    var salary;
    (function (salary) {
        function DisplaySalary(value) { console.log("Display Salary " + value); }
        salary.DisplaySalary = DisplaySalary;
    })(salary = employee.salary || (employee.salary = {}));
    function displayDataType(id) {
        console.log("DataType of Id: " + typeof (id));
    }
    employee.displayDataType = displayDataType;
})(employee || (employee = {}));
