function validation() {
    let x = document.forms["myform"]["empid"].value
    let y = /\w{5,}/g;
    var result = x.match(y);

    if (!result) {
        document.getElementById("validationerror").value = "!!! Please Enter Atleats 5 character EmployeeID"
        return false;
    }else{
        var empid = document.getElementById("employeeid").value;
        var empname = document.getElementById("employeename").value;
        var age = document.getElementById("age").value;
        var gender = document.getElementById("gender").value;
        var designation = document.getElementById("designation").value;
        var salary = document.getElementById("salary").value;
        var locations = document.getElementById("locations").value;
        var email = document.getElementById("email").value;
        var dateofjoining = document.getElementById("dateofjoining").value;
        var contactnumber = document.getElementById("contactnumber").value;
        
        console.log(empid);
        // myform.submit();
        var newwin = window.open();
        newwin.document.write(
            "<h2>your data submitted succesfully</h2>"
            +"<br><label>Id : </label>" + empid
            +"<br><label>Name : </label>" + empname
            +"<br><label>Age : </label>" + age
            +"<br><label>Gender : </label>" + gender
            +"<br><label>Designation : </label>" + designation
            +"<br><label>Salary : </label>" + salary
            +"<br><label>Location : </label>" + locations
            +"<br><label>Email : </label>" + email
            +"<br><label>JoiningDate : </label>" + dateofjoining
            +"<br><label>ContactNumber : </label>" + contactnumber
        )
    }


}
