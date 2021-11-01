function checkinput() {
    var Date = document.getElementById("date").value;

    var date = Date.split("-");
    console.log(date);

    var month31 = ["1", "3", "5", "7", "9", "11"]
    var month30 = ["4", "6", "8", "10", "12"]

    if (date[1] == 2 && date[0] == 29) {
        if (date[2] % 4 == 0 && date[2] % 100 !== 0 && date[2] % 400 !== 0) {
            alert("Date is Valid!!!! and Its Leep Year");
        } else {
            alert("Date is Not Valid, Its Not a Leep Year!!!!")
        }
    }
    else if (date[1] == 2) {
        if (date[0] <= 28) {
            alert("Date is Valid!!!!");
        } else {
            alert("Date is Not Valid!!!!");
        }
    } else if (month30.includes(date[1])) {
        if (date[0] <= 30) {
            alert("Date is Valid!!!!");
        } else {
            alert("Date is Not Valid!!!!");
        }
    } else if (month31.includes(date[1])) {
        if (date[0] <= 31) {
            alert("Date is Valid!!!!!")
        } else {
            alert("Date is Not Valid!!!!");
        }
    }
}
console.log(Date)

