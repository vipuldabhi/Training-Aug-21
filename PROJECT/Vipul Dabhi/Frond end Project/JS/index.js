$(document).ready(function () {

    sessionStorage.setItem("loginstatus", 0);

    // main section

    $(".main").append($("<div></div>").attr("class", "container mt-5").append($("<div></div>").attr("class", "row imgandquots")))
    $(".imgandquots").append($("<div></div>").attr("class", "col-sm-6 d-flex justify-content-center align-items-center flex-column")
        .append($("<h5>Sharing Tiffin was just an excuse,</h5>")).append($("<h5>actually salivated to share love...</h5>"))
        .append($("<button>Login</button>").attr("class", "login btn btn-outline-danger my-2"))
        .append($("<button>LogOut</button>").attr("class", "logout-btn btn btn-outline-danger my-2")))

    $(".imgandquots").append($("<div></div>").attr("class", "col-sm-6")
        .append($("<figure></figure>").append($("<img>").attr({
            src: "./Assets/food_image.jpg",
            alt: "food_img",
            class: "img-fluid shadow "
        }))))

    // login prompt secftion

    $("#login").append($("<div></div>").attr("class", "container").append($("<div></div>").attr("class", "popup")))
    $(".popup").append($("<div></div>").attr("class", "popup-content"))
    $(".popup-content").append($("<input>").attr({ type: "text", placeholder: "Enter UserName", id: "username", "required": true }))
    $(".popup-content").append($("<input>").attr({ type: "password", placeholder: "Enter password", id: "password", "required": true }))
    $(".popup-content").append($("<button>Login</button>").attr("class", "login-btn btn btn-outline-danger mx-3"))
    $(".popup-content").append($("<button>Close</button>").attr("class", "closebtn btn btn-outline-danger"))


    $(".login").click(function () {
        $(".popup").css("display", "flex");
    });
    $(".closebtn").click(function () {
        $(".popup").css("display", "none");
    });

    $(".login-btn").click(function () {



        var username = $("#username").val();
        var password = $("#password").val();

        var user = [{ "username": username, "password": password }]

        if (!sessionStorage.user) {
            if (username !== "" && password !== "") {
                sessionStorage.setItem("user", JSON.stringify(user));
                $(".login").css("display","none");
                $(".logout-btn").css("display","flex");

            } else {
                alert("Please Enter Username and Password!!!!")
            }
        } else {
            alert("You Are Already LogedIn!!!!")
        }

        $(".popup").css("display", "none");

    });

    $(".logout-btn").click(function(){
        sessionStorage.removeItem("user");
        window.location.href = "";
    });


    // initiative section

    $(".initiative").append($("<div></div>").attr("class", "container my-5")
        .append($("<div></div>").attr("class", "text-center")
            .append($("<div>A Greate Initiative</div>").attr("class", "display-6"))
            .append($("<hr />").attr("class", "w-50 mx-auto"))));
    
    // e-bycycle section

    $(".initiative").append($("<div></div>").attr("class", "container my-5")
        .append($("<div><div>").attr("class", "row")
            .append($("<div></div>").attr("class", "col-sm-6 e-bycycle"))
            .append($("<div></div>")
                .attr("class", "border col-sm-6 about-initiative d-flex flex-column justify-content-around text-align-start p-5"))))

    $(".e-bycycle").append($("<img>").attr({ "src": "./Assets/e-bike.jpg", "alt": "e-bike_image" }))
    $(".about-initiative").append($("<h3>One Step to Save Environment</h3>")).append($("<p></p>")
        .text("This is Unique Initiative by Us,In this We can Delivered Your Tiffin Only and Only by a Electric-bicycle to Save the Envirnment and Fuel for Our Next Generation"))
        .append($("<h3></h3>").text("Show Your Love Towards the Environment"))



    // food box waste section

    $(".initiative").append($("<div></div>").attr("class", "container my-5")
        .append($("<div><div>").attr("class", "row")
            .append($("<div></div>")
                .attr("class", "border col-sm-6 about-initiative2 d-flex flex-column justify-content-center text-align-start p-5"))
            .append($("<div></div>").attr("class", "col-sm-6 box-waste b d-flex flex-row"))))

    $(".about-initiative2").append($("<h3>Onether Step to Save Environment</h3>")).append($("<p></p>")
        .text("In This One , If You Collect Empty waste Tiffin Box For a Month And Returned it to Oue Company, Then We Can Give You A Greate Surprice Gift For Your One Step For Save Environment,For Store Empty Boxes We Can Provide A Dustbin").attr("class", "mt-5 mb-5"))
        .append($("<h3></h3>").text("I only feel angry when I see waste...."))
    $(".box-waste").append($("<img>").attr({ "src": "./Assets/box.jpg", "alt": "food-waste_image", "class": "img-fluid w-50" }))
    $(".box-waste").append($("<img>").attr({ "src": "./Assets/food waste.jpg", "alt": "food-waste_image", "class": "img-fluid w-50" }))



    // Menu Section

    $(".menu").append($("<div></div>").attr("class", "container my-5")
        .append($("<div></div>").attr("class", "text-center")
            .append($("<div>Explore</div>").attr("class", "display-6"))
            .append($("<hr />").attr("class", "w-25 mx-auto"))));

    $(".menu").append($("<div></div>").attr("class", "container")
        .append($("<div></div>").attr("class", "menutable")))
    $(".menutable").append($("<table></table>").attr("class", "table tbldata "))
    $(".tbldata").append($("<thead></thead>"))
    $("thead").append($("<tr></tr>").append($("<th></th>")).append($("<th>Lunch</th>"))
        .append($("<th>Dinner</th>")).append($("<th>Lunch-Dinner</th>")))
    $(".tbldata").append($("<tbody></tbody>"))
    $("tbody").append($("<tr></tr>").append($("<td>1-Week</td>")).append($("<td>&#x20B9; 700</td>"))
        .append($("<td>&#x20B9; 500</td>")).append($("<td>&#x20B9; 1200</td>")))
    $("tbody").append($("<tr></tr>").append($("<td>1-Month</td>")).append($("<td>&#x20B9; 2800</td>"))
        .append($("<td>&#x20B9; 1900</td>")).append($("<td>&#x20B9; 4700</td>")))
    $("tbody").append($("<tr></tr>").append($("<td>3-Month</td>")).append($("<td>&#x20B9; 8300</td>"))
        .append($("<td>&#x20B9; 5800</td>")).append($("<td>&#x20B9; 13100</td>")))
    $("tbody").append($("<tr></tr>").append($("<td>Sunday</td>")).append($("<td>&#x20B9; 100</td>"))
        .append($("<td>&#x20B9; 70</td>")).append($("<td>&#x20B9; 170</td>")))


    // foodies-motivation section

    $(".foodies-motivation").append($("<div></div>").attr("class", "container my-5")
        .append($("<div></div>").attr("class", "text-center")
            .append($("<div>Foodies-Motivation</div>").attr("class", "display-6"))
            .append($("<hr />").attr("class", "w-25 mx-auto"))));

    $(".foodies-motivation").append($("<div></div>").attr("class", "container")
        .append($("<div></div>").attr("class", "row cards")))
    $(".cards").append($("<div></div>").attr("class", "col-md-4").append($("<div></div>").attr("class", "card mb-3")
        .append($("<img>").attr({ "class": "card-img-top img-fluid", "src": "./Assets/3.jpg", "alt": "food_image" }))
        .append($("<div></div>").attr("class", "card-body").append($("<p></p>")
            .text("“So long as you have food in your mouth you have solved all questions for the time being.”")))))
    $(".cards").append($("<div></div>").attr("class", "col-md-4").append($("<div></div>").attr("class", "card mb-3")
        .append($("<img>").attr({ "class": "card-img-top img-fluid", "src": "./Assets/4.jpg", "alt": "food_image" }))
        .append($("<div></div>").attr("class", "card-body").append($("<p></p>")
            .text("“To me, food is as much about the moment, the occasion, the location and the company as it is about the taste.”")))))
    $(".cards").append($("<div></div>").attr("class", "col-md-4").append($("<div></div>").attr("class", "card mb-3")
        .append($("<img>").attr({ "class": "card-img-top img-fluid", "src": "./Assets/6.jpg", "alt": "food_image" }))
        .append($("<div></div>").attr("class", "card-body").append($("<p></p>")
            .text("“Food is really and truly the most effective medicine.”")))))




    if (!sessionStorage.user) {
        $(".login").css("display","flex");
    } else {
        $(".logout-btn").css("display","flex");    
    }

})


// Login Button with login-btn class in popup


// $(document).ready(function () {

//     $.getJSON("./database/user.json", function (users) {
//         localStorage.setItem("users", JSON.stringify(users));
//         var retrievedusers = JSON.parse(localStorage.getItem('users'));
//         console.log(retrievedusers);
//     });

//     $(".login-btn").click(function () {
//         let checkusername = JSON.parse(localStorage.getItem("users"))
//         console.log(checkusername)
//         // let checkpassword = 
//         // if(){

//         // }
//     });

// });