import * as Operation from "./operation";

console.log("Enter 1 for Show Restaurant List");
console.log("Enter 2 for Book a Table");
console.log("Enter 3 for exit");

var operation : number = 3;
var flag : number = 1;

// while(flag == 1){

switch(operation){
    case 1:
        Operation.listOfRestaurant();
        break
    case 2:
        Operation.BookingOfTable();
        break;
    case 3:
        Operation.viewBookingData();
        break;
    case 4:
        flag = 0;
        break
    default:
        console.log("Invalid Choice");
        break;
}

// }