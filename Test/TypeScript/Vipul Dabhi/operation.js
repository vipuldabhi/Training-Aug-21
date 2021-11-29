"use strict";
exports.__esModule = true;
exports.viewBookingData = exports.BookingOfTable = exports.listOfRestaurant = void 0;
var data = require("./database");
function listOfRestaurant() {
    var list = data.Restaurant;
    for (var _i = 0, list_1 = list; _i < list_1.length; _i++) {
        var i = list_1[_i];
        console.log("RestaurantId : ".concat(i.RestaurantId, " Name : ").concat(i.Name, " Location : ").concat(i.Location));
    }
    console.log("Enter Restaurant Id In which You Want to view Table Details");
    var ResId = 1;
    if (ResId === 1) {
        for (var _a = 0, _b = data.Restaurant_1_Capacity; _a < _b.length; _a++) {
            var x = _b[_a];
            console.log("DiningRoomId : ".concat(x.DiningRoomId, " Capacity Of People : ").concat(x.Capacity));
        }
    }
    else if (ResId === 2) {
        for (var _c = 0, _d = data.Restaurant_2_Capacity; _c < _d.length; _c++) {
            var y = _d[_c];
            console.log("DiningRoomId : ".concat(y.DiningRoomId, " Capacity Of People : ").concat(y.Capacity));
        }
    }
    else if (ResId === 3) {
        for (var _e = 0, _f = data.Restaurant_3_Capacity; _e < _f.length; _e++) {
            var z = _f[_e];
            console.log("DiningRoomId : ".concat(z.DiningRoomId, " Capacity Of People : ").concat(z.Capacity));
        }
    }
    else if (ResId === 4) {
        for (var _g = 0, _h = data.Restaurant_4_Capacity; _g < _h.length; _g++) {
            var j = _h[_g];
            console.log("DiningRoomId : ".concat(j.DiningRoomId, " Capacity Of People : ").concat(j.Capacity));
        }
    }
}
exports.listOfRestaurant = listOfRestaurant;
function BookingOfTable() {
    console.log("Enter RestaurantId , DiningRoom ID And Date");
    var restaurantId = 2;
    var dininggRoomId = 21;
    var date = new Date("2021-11-29");
    var checkValue = checkForAvailability(date, dininggRoomId);
    var bookingData = { RestaurantId: restaurantId,
        DiningRoomId: dininggRoomId,
        Date: date };
    var checkData = { DateOfBooking: date,
        DiningId: dininggRoomId };
    if (checkValue === "Available") {
        data.BookedTable.push(bookingData);
        data.checkTable.push(checkData);
        var token = restaurantId + dininggRoomId;
        console.log("Your Token For Booked Table Is ".concat(token));
    }
    else if (checkValue === "Late") {
        console.log("You Are Too Late For Booking");
    }
    else if (checkValue === "Early") {
        console.log("You Are Too Early For Booking");
    }
}
exports.BookingOfTable = BookingOfTable;
function viewBookingData() {
    console.log("List Of Booked Table");
    for (var _i = 0, _a = data.BookedTable; _i < _a.length; _i++) {
        var k = _a[_i];
        console.log("RestaurantId : ".concat(k.RestaurantId, " DiningRoomId : ").concat(k.DiningRoomId, " Date Of Booking : ").concat(k.Date));
    }
}
exports.viewBookingData = viewBookingData;
function checkForAvailability(date, id) {
    var currentDate = new Date();
    var hours = Math.abs(currentDate - date) / 36e5;
    if (hours < 6 && !date < currentDate) {
        return ("Late");
    }
    else if (hours > 720 && !date < currentDate) {
        return ("Early");
    }
    else if (hours > 6 && hours < 720 && !date < currentDate) {
        return ("Available");
    }
    else {
        console.log("Invalid Choice");
    }
}
