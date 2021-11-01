function calculate() {

    //get the values of number which user enter

    var number1 = parseFloat(document.getElementById('num1').value);
    var number2 = parseFloat(document.getElementById('num2').value);

    //check for which operation user select

    if (document.getElementById('addition').checked == true) {
        var operation = document.getElementById("addition").value;
    }
    else if (document.getElementById('subtraction').checked == true) {
        var operation = document.getElementById("subtraction").value;
    }
    else if (document.getElementById('multiplication').checked == true) {
        var operation = document.getElementById("multiplication").value;
    }
    else if (document.getElementById('division').checked == true) {
        var operation = document.getElementById("division").value;
    } else {
        alert("Please Select Operation You Want to Perform");
    }

    //check for which operation is perform

    if (operation == "1") {
        document.getElementById("result").value = number1 + number2;
    }
    else if (operation == "2") {
        document.getElementById("result").value = number1 - number2;
    }
    else if (operation == "3") {
        document.getElementById("result").value = number1 * number2;
    }
    else if (operation == "4") {
        document.getElementById("result").value = number1 / number2;
    }

}

//for reset the values

function reset() {
    document.getElementById("num1").value = "";
    document.getElementById("num2").value = "";
    document.getElementsByName("operation").value = "";
}
