"use strict";
// There is a retail shop which need to manage the inventory, whenever some purchase 
// is being made product quantity should be reduced, if quanity is less than 5 reorder 
// request should be raised.
exports.__esModule = true;
// Design an interface and classes for the same.
var Classes_1 = require("./Classes"); // Import Class
// var flag:number = 0;
// while(flag === 1){
var value = 2;
var obj = new Classes_1.buyProduct();
switch (value) {
    case 1: {
        obj.resuceItemQuantity(1);
        break;
    }
    case 2: {
        obj.resuceItemQuantity(2);
        break;
    }
    case 3: {
        obj.resuceItemQuantity(3);
        break;
    }
    case 4: {
        // flag = 0;
    }
    default: {
        console.log("Invalid Choice");
        break;
    }
}
// }
