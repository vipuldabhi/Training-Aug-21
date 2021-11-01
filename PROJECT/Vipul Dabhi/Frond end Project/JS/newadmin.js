$(document).ready(function(){

    $(".mondaylunch").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-monday-lunch").css("display", "flex");
    });
    $(".tuesdaylunch").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-tuesday-lunch").css("display", "flex");
    });
    $(".wednesdaylunch").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-wednesday-lunch").css("display", "flex");
    });
    $(".thursdaylunch").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-thursday-lunch").css("display", "flex");
    });
    $(".fridaylunch").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-friday-lunch").css("display", "flex");
    });
    $(".saturdaylunch").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-saturday-lunch").css("display", "flex");
    });    
    $(".sundaylunch").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-sunday-lunch").css("display", "flex");
    });

    // dinner

    $(".mondaydinner").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-monday-dinner").css("display", "flex");
    });
    $(".tuesdaydinner").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-tuesday-dinner").css("display", "flex");
    });
    $(".wednesdaydinner").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-wednesday-dinner").css("display", "flex");
    });
    $(".thursdaydinner").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-thursday-dinner").css("display", "flex");
    });
    $(".fridaydinner").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-friday-dinner").css("display", "flex");
    });
    $(".saturdaydinner").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-saturday-dinner").css("display", "flex");
    });    
    $(".sundaydinner").click(function(){
        $(".popup").css("display", "flex");
        $(".popup-content-sunday-dinner").css("display", "flex");
    });


    $(".submitdata").click(function(){
        $(".popup").css("display", "none");
        $(".popup-content-monday-lunch").css("display", "none");
        $(".popup-content-tuesday-lunch").css("display", "none");
        $(".popup-content-wednesday-lunch").css("display", "none");
        $(".popup-content-thursday-lunch").css("display", "none");
        $(".popup-content-friday-lunch").css("display", "none");
        $(".popup-content-saturday-lunch").css("display", "none");
        $(".popup-content-sunday-lunch").css("display", "none");

        $(".popup-content-monday-dinner").css("display", "none");
        $(".popup-content-tuesday-dinner").css("display", "none");
        $(".popup-content-wednesday-dinner").css("display", "none");
        $(".popup-content-thursday-dinner").css("display", "none");
        $(".popup-content-friday-dinner").css("display", "none");
        $(".popup-content-saturday-dinner").css("display", "none");
        $(".popup-content-sunday-dinner").css("display", "none");
    });

    // Add Item to Monday

    $(".addtomonday").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Monday", "");
        if (!localStorage.mondaymenu) {
            var x = [m];
            localStorage.setItem("mondaymenu", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("mondaymenu");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("mondaymenu", JSON.stringify(y));
        }
        window.location.href = "";
    });
    var mon = JSON.parse(localStorage.getItem("mondaymenu"));
    $.each(mon, function (i, result) {
        // console.log(result)
        $(".m").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefrommonday btn btn-outline-danger", "id": i }))));
    });

    // Add Item to Tuesday

    $(".addtotuesday").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Tuesday", "");
        if (!localStorage.tuesdaymenu) {
            var x = [m];
            localStorage.setItem("tuesdaymenu", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("tuesdaymenu");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("tuesdaymenu", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var tue = JSON.parse(localStorage.getItem("tuesdaymenu"));
    $.each(tue, function (i, result) {
        // console.log(result)
        $(".t").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromtuesday btn btn-outline-danger", "id": i }))));
    });

    // Add Item to Wednesday

    $(".addtowednesday").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Wednesday", "");
        if (!localStorage.wednesdaymenu) {
            var x = [m];
            localStorage.setItem("wednesdaymenu", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("wednesdaymenu");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("wednesdaymenu", JSON.stringify(y));

        }
        window.location.href = "";
    });

    var wed = JSON.parse(localStorage.getItem("wednesdaymenu"));
    $.each(wed, function (i, result) {
        // console.log(result)
        $(".w").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromwednesday btn btn-outline-danger", "id": i }))));
    });
    // Add Item to Thursday

    $(".addtothursday").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Thursday", "");
        if (!localStorage.thursdaymenu) {
            var x = [m];
            localStorage.setItem("thursdaymenu", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("thursdaymenu");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("thursdaymenu", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var thu = JSON.parse(localStorage.getItem("thursdaymenu"));
    $.each(thu, function (i, result) {
        // console.log(result)
        $(".th").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromthursday btn btn-outline-danger", "id": i }))));
    });
    // Add Item to Friday

    $(".addtofriday").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Friday", "");
        if (!localStorage.fridaymenu) {
            var x = [m];
            localStorage.setItem("fridaymenu", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("fridaymenu");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("fridaymenu", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var fri = JSON.parse(localStorage.getItem("fridaymenu"));
    $.each(fri, function (i, result) {
        // console.log(result)
        $(".f").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromfriday btn btn-outline-danger", "id": i }))));
    });
    // Add Item to Saturday

    $(".addtosaturday").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Friday", "");
        if (!localStorage.saturdaymenu) {
            var x = [m];
            localStorage.setItem("saturdaymenu", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("saturdaymenu");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("saturdaymenu", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var sat = JSON.parse(localStorage.getItem("saturdaymenu"));
    $.each(sat, function (i, result) {
        // console.log(result)
        $(".sa").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromsaturday btn btn-outline-danger", "id": i }))));
    });
    // Add Item to Sunday

    $(".addtosunday").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Sunday", "");
        if (!localStorage.sundaymenu) {
            var x = [m];
            localStorage.setItem("sundaymenu", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("sundaymenu");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("sundaymenu", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var sun = JSON.parse(localStorage.getItem("sundaymenu"));
    $.each(sun, function (i, result) {
        // console.log(result)
        $(".su").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromsunday btn btn-outline-danger", "id": i }))));
    });


    //##### REMOVE ITEM #####

    // MONDAY
    $(".removefrommonday").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("mondaymenu"));
        menu.splice(i, 1);
        localStorage.setItem("mondaymenu", JSON.stringify(menu));
        window.location.href = "";
    })

    // TUESDAY
    $(".removefromtuesday").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("tuesdaymenu"));
        menu.splice(i, 1);
        localStorage.setItem("tuesdaymenu", JSON.stringify(menu));
        window.location.href = "";
    })

    // WEDNESDAY
    $(".removefromwednesday").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("wednesdaymenu"));
        menu.splice(i, 1);
        localStorage.setItem("wednesdaymenu", JSON.stringify(menu));
        window.location.href = "";
    })

    // THURSDAY
    $(".removefromthursday").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("thursdaymenu"));
        menu.splice(i, 1);
        localStorage.setItem("thursdaymenu", JSON.stringify(menu));
        window.location.href = "";
    })

    // FRIDAY
    $(".removefromfriday").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("fridaymenu"));
        menu.splice(i, 1);
        localStorage.setItem("fridaymenu", JSON.stringify(menu));
        window.location.href = "";
    })

    // SATURDAY
    $(".removefromsaturday").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("saturdaymenu"));
        menu.splice(i, 1);
        localStorage.setItem("saturdaymenu", JSON.stringify(menu));
        window.location.href = "";
    })

    // SUNDAY
    $(".removefromsunday").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("sundaymenu"));
        menu.splice(i, 1);
        localStorage.setItem("sundaymenu", JSON.stringify(menu));
        window.location.href = "";
    })


    // LUNCH MENU END



    // DINNER MENU START


    // Add Item to Monday

    $(".addtomondaydinner").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Mondaydinner", "");
        if (!localStorage.mondaymenudinner) {
            var x = [m];
            localStorage.setItem("mondaymenudinner", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("mondaymenudinner");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("mondaymenudinner", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var mon = JSON.parse(localStorage.getItem("mondaymenudinner"));
    $.each(mon, function (i, result) {
        // console.log(result)
        $(".mdinner").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefrommondaydinner btn btn-outline-danger", "id": i }))));
    });


    // Add Item to Tuesday

    $(".addtotuesdaydinner").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Tuesdaydinner", "");
        if (!localStorage.tuesdaymenudinner) {
            var x = [m];
            localStorage.setItem("tuesdaymenudinner", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("tuesdaymenudinner");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("tuesdaymenudinner", JSON.stringify(y));
        }
        window.location.href = "";
    }); 

    var tue = JSON.parse(localStorage.getItem("tuesdaymenudinner"));
    $.each(tue, function (i, result) {
        // console.log(result)
        $(".tdinner").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromtuesdaydinner btn btn-outline-danger", "id": i }))));
    });

    // Add Item to Wednesday

    $(".addtowednesdaydinner").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Wednesdaydinner", "");
        if (!localStorage.wednesdaymenudinner) {
            var x = [m];
            localStorage.setItem("wednesdaymenudinner", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("wednesdaymenudinner");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("wednesdaymenudinner", JSON.stringify(y));

        }
        window.location.href = "";
    });

    var wed = JSON.parse(localStorage.getItem("wednesdaymenudinner"));
    $.each(wed, function (i, result) {
        // console.log(result)
        $(".wdinner").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromwednesdaydinner btn btn-outline-danger", "id": i }))));
    });
    // Add Item to Thursday

    $(".addtothursdaydinner").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Thursdaydinner", "");
        if (!localStorage.thursdaymenudinner) {
            var x = [m];
            localStorage.setItem("thursdaymenudinner", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("thursdaymenudinner");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("thursdaymenudinner", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var thu = JSON.parse(localStorage.getItem("thursdaymenudinner"));
    $.each(thu, function (i, result) {
        // console.log(result)
        $(".thdinner").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromthursdaydinner btn btn-outline-danger", "id": i }))));
    });
    // Add Item to Friday

    $(".addtofridaydinner").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Fridaydinner", "");
        if (!localStorage.fridaymenudinner) {
            var x = [m];
            localStorage.setItem("fridaymenudinner", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("fridaymenudinner");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("fridaymenudinner", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var fri = JSON.parse(localStorage.getItem("fridaymenudinner"));
    $.each(fri, function (i, result) {
        // console.log(result)
        $(".fdinner").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromfridaydinner btn btn-outline-danger", "id": i }))));
    });
    // Add Item to Saturday

    $(".addtosaturdaydinner").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Saturdaydinner", "");
        if (!localStorage.saturdaymenudinner) {
            var x = [m];
            localStorage.setItem("saturdaymenudinner", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("saturdaymenudinner");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("saturdaymenudinner", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var sat = JSON.parse(localStorage.getItem("saturdaymenudinner"));
    $.each(sat, function (i, result) {
        // console.log(result)
        $(".sadinner").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromsaturdaydinner btn btn-outline-danger", "id": i }))));
    });
    // Add Item to Sunday

    $(".addtosundaydinner").click(function () {
        var m = prompt("Enter Iteam  You Want to Add in Sundaydinner", "");
        if (!localStorage.sundaymenudinner) {
            var x = [m];
            localStorage.setItem("sundaymenudinner", JSON.stringify(x));
        } else {
            var x = localStorage.getItem("sundaymenudinner");
            var y = JSON.parse(x)
            y.push(m);

            localStorage.setItem("sundaymenudinner", JSON.stringify(y));
        }
        window.location.href = "";
    });

    var sun = JSON.parse(localStorage.getItem("sundaymenudinner"));
    $.each(sun, function (i, result) {
        // console.log(result)
        $(".sudinner").append($("<tr></tr>")
            .append($("<td></td>").text(result))
            .append($("<td></td>").append($("<button>remove</button>")
                .attr({ "class": "removefromsundaydinner btn btn-outline-danger", "id": i }))));
    });


    //##### REMOVE ITEM #####

    // MONDAY
    $(".removefrommondaydinner").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("mondaymenudinner"));
        menu.splice(i, 1);
        localStorage.setItem("mondaymenudinner", JSON.stringify(menu));
        window.location.href = "";
    })

    // TUESDAY
    $(".removefromtuesdaydinner").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("tuesdaymenudinner"));
        menu.splice(i, 1);
        localStorage.setItem("tuesdaymenudinner", JSON.stringify(menu));
        window.location.href = "";
    })

    // WEDNESDAY
    $(".removefromwednesdaydinner").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("wednesdaymenudinner"));
        menu.splice(i, 1);
        localStorage.setItem("wednesdaymenudinner", JSON.stringify(menu));
        window.location.href = "";
    })

    // THURSDAY
    $(".removefromthursdaydinner").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("thursdaymenudinner"));
        menu.splice(i, 1);
        localStorage.setItem("thursdaymenudinner", JSON.stringify(menu));
        window.location.href = "";
    })

    // FRIDAY
    $(".removefromfridaydinner").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("fridaymenudinner"));
        menu.splice(i, 1);
        localStorage.setItem("fridaymenudinner", JSON.stringify(menu));
        window.location.href = "";
    })

    // SATURDAY
    $(".removefromsaturdaydinner").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("saturdaymenudinner"));
        menu.splice(i, 1);
        localStorage.setItem("saturdaymenudinner", JSON.stringify(menu));
        window.location.href = "";
    })

    // SUNDAY
    $(".removefromsundaydinner").click(function () {
        var i = (this.id);
        var menu = JSON.parse(localStorage.getItem("sundaymenudinner"));
        menu.splice(i, 1);
        localStorage.setItem("sundaymenudinner", JSON.stringify(menu));
        window.location.href = "";
    })


    
    // SHOW ALL ORDER IN TABLE


    var orderdata = JSON.parse(localStorage.getItem("userorder"));
    $.each(orderdata, function (i, result) {
        $(".customer").append($("<tr></tr>").append($("<td></td>").text(i))
            .append($("<td></td>").text(result.fullname))
            .append($("<td></td>").text(result.email))
            .append($("<td></td>").text(result.mobileno))
            .append($("<td></td>").text(result.area))
            .append($("<td></td>").text(result.time))
            .append($("<td></td>").text(result.type))
            .append($("<td></td>").text(result.plan))
            .append($("<td></td>").text(result.extra))
            .append($("<td></td>").text(result.startdate)));
    });



    // SHOW ALL CONTACT US INFO IN TABLE


    var contactdata = JSON.parse(localStorage.getItem("contactdata"));
    $.each(contactdata, function (i, result) {
        if(result.status == "0"){
            $(".contact").append($("<tr></tr>").append($("<td></td>").text(i))
            .append($("<td></td>").text(result.fullname))
            .append($("<td></td>").text(result.email))
            .append($("<td></td>").text(result.contactno))
            .append($("<td></td>").text(result.subject))
            .append($("<td></td>").text(result.message))
            .append($("<td></td>").text(result.date))
            .append($("<td></td>").text(result.date).append($("<button>Solve</button>").attr({"class":"solve btn btn-outline-primary","id":i}))));
        }
    });

    $(".solve").click(function(){

        var x = (this.id);
        var checkcontactdata = JSON.parse(localStorage.getItem("contactdata"));
            
        checkcontactdata[x].status = 1;

        localStorage.setItem("contactdata", JSON.stringify(checkcontactdata));
        window.location.href = "";
    });


    //##### CHECK FOR LOGIN #####


    if (!sessionStorage.admin) {
        $("#editmenu").css("display", "none");
        $("#customer").css("display", "none");
        $("#contact").css("display", "none");
        $("#logout-admin").css("display", "none");
        $(".notloginasadmin").css("display", "flex");
        alert("please Login as Admin!!!!");
    } else {

        $(".notloginasadmin").css("display", "none");
        

    }


    // ADMIN LOGIN


    $(".loginasadmin").click(function () {
        var username = $("#admin-username").val();
        var password = $("#admin-password").val();

        var admin = [{ "username": username, "password": password }];

        sessionStorage.setItem("admin", JSON.stringify(admin));

        // $("#editmenu").css("display", "show");
        // $("#customer").css("display", "show");
        // $("#contact").css("display", "show");
        window.location.href = "";
    });

    $(".logout-admin").click(function(){

        sessionStorage.removeItem("admin");
        window.location.href = "";

    });

});


