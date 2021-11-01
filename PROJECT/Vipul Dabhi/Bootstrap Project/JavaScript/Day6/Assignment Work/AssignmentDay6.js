function additem1() {

    var productId = document.getElementById("id-1").innerHTML;
    var productName = document.getElementById("name-1").innerHTML;
    var price = document.getElementById("price-1").innerHTML;
    var quantity = document.getElementById("quantity-1").innerHTML;

    var mycart = [];
    mycart[0] = productId;
    mycart[1] = productName;
    mycart[2] = price;


    if (typeof (Storage) !== "undefined") {
        if (localStorage.QuantityOfItem1) {
            var count = localStorage.getItem("QuantityOfItem1")
            count = Number(count) + 1;
            localStorage.setItem("QuantityOfItem1", count)

        }
    } else {
        document.getElementById("result").innerHTML =
            "Sorry, your browser does not support web storage...";
    }

    // alert(mycart);

    if (typeof (Storage) !== "undefined") {
        if (!localStorage.item1 && !localStorage.QuantityOfItem1) {

            localStorage.setItem("item1", JSON.stringify(mycart));
            localStorage.setItem("QuantityOfItem1", quantity);

        }
    } else {
        document.getElementById("result").innerHTML =
            "Sorry, your browser does not support web storage...";
    }

}


function additem2() {

    var productId = document.getElementById("id-2").innerHTML;
    var productName = document.getElementById("name-2").innerHTML;
    var price = document.getElementById("price-2").innerHTML;
    var quantity = document.getElementById("quantity-2").innerHTML;

    var mycart2 = [];
    mycart2[0] = productId;
    mycart2[1] = productName;
    mycart2[2] = price;

    if (typeof (Storage) !== "undefined") {
        if (localStorage.QuantityOfItem2) {
            var count = localStorage.getItem("QuantityOfItem2")
            count = Number(count) + 1;
            localStorage.setItem("QuantityOfItem2", count)

        }
    } else {
        document.getElementById("result").innerHTML =
            "Sorry, your browser does not support web storage...";
    }


    if (typeof (Storage) !== "undefined") {
        if (!localStorage.item2 && !localStorage.QuantityOfItem2) {

            localStorage.setItem("item2", JSON.stringify(mycart2));
            localStorage.setItem("QuantityOfItem2", quantity);

        }
    } else {
        document.getElementById("result").innerHTML =
            "Sorry, your browser does not support web storage...";
    }

}


function additem3() {

    var productId = document.getElementById("id-3").innerHTML;
    var productName = document.getElementById("name-3").innerHTML;
    var price = document.getElementById("price-3").innerHTML;
    var quantity = document.getElementById("quantity-3").innerHTML;

    var mycart3 = [];
    mycart3[0] = productId;
    mycart3[1] = productName;
    mycart3[2] = price;

    if (typeof (Storage) !== "undefined") {
        if (localStorage.QuantityOfItem3) {
            var count = localStorage.getItem("QuantityOfItem3")
            count = Number(count) + 1;
            localStorage.setItem("QuantityOfItem3", count)

        }
    } else {
        document.getElementById("result").innerHTML =
            "Sorry, your browser does not support web storage...";
    }


    if (typeof (Storage) !== "undefined") {
        if (!localStorage.item3 && !localStorage.QuantityOfItem3) {

            localStorage.setItem("item3", JSON.stringify(mycart3));
            localStorage.setItem("QuantityOfItem3", quantity);

        }
    } else {
        document.getElementById("result").innerHTML =
            "Sorry, your browser does not support web storage...";
    }


}


function additem4() {

    var productId = document.getElementById("id-4").innerHTML;
    var productName = document.getElementById("name-4").innerHTML;
    var price = document.getElementById("price-4").innerHTML;
    var quantity = document.getElementById("quantity-4").innerHTML;

    var mycart4 = [];
    mycart4[0] = productId;
    mycart4[1] = productName;
    mycart4[2] = price;

    if (typeof (Storage) !== "undefined") {
        if (localStorage.QuantityOfItem4) {
            var count = localStorage.getItem("QuantityOfItem4")
            count = Number(count) + 1;
            localStorage.setItem("QuantityOfItem4", count)

        }
    } else {
        document.getElementById("result").innerHTML =
            "Sorry, your browser does not support web storage...";
    }


    if (typeof (Storage) !== "undefined") {
        if (!localStorage.item4 && !localStorage.QuantityOfItem4) {

            localStorage.setItem("item4", JSON.stringify(mycart4));
            localStorage.setItem("QuantityOfItem4", quantity);

        }
    } else {
        document.getElementById("result").innerHTML =
            "Sorry, your browser does not support web storage...";
    }


}

function viewCart() {
    console.log(localStorage.getItem("item1"));
    console.log(localStorage.getItem("item2"));
    console.log(localStorage.getItem("item3"));
    console.log(localStorage.getItem("item4"));
    console.log(localStorage.getItem("QuantityOfItem1"));
    console.log(localStorage.getItem("QuantityOfItem2"));
    console.log(localStorage.getItem("QuantityOfItem3"));
    console.log(localStorage.getItem("QuantityOfItem4"));
}

