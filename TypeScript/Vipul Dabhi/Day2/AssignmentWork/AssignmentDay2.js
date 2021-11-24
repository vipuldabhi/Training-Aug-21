// There is a retail shop which need to manage the inventory, whenever some purchase 
// is being made product quantity should be reduced, if quanity is less than 5 reorder 
// request should be raised.
var buyProduct = /** @class */ (function () {
    function buyProduct() {
        this.Item1Quantity = 7;
        this.Item2Quantity = 6;
        this.Item3Quantity = 5;
    }
    buyProduct.prototype.resuceItemQuantity = function (value) {
        if (value === 1) {
            this.Item1Quantity = this.Item1Quantity - 1;
            console.log("Item1 Quantity Reduced Successfully");
            console.log("Remening Quantity Of Item1 is ".concat(this.Item1Quantity));
            if (this.Item1Quantity < 5) {
                console.log("ReOrder Request For Item1 is Raised");
            }
        }
        else if (value === 2) {
            this.Item2Quantity = this.Item2Quantity - 1;
            console.log("Item2 Quantity Reduced Successfully");
            console.log("Remening Quantity Of Item2 is ".concat(this.Item2Quantity));
            if (this.Item1Quantity < 5) {
                console.log("ReOrder Request For Item2 is Raised");
            }
        }
        else {
            this.Item3Quantity = this.Item3Quantity - 1;
            console.log("Item3 Quantity Reduced Successfully");
            console.log("Remening Quantity Of Item2 is ".concat(this.Item2Quantity));
            if (this.Item1Quantity < 5) {
                console.log("ReOrder Request For Item1 is Raised");
            }
        }
    };
    return buyProduct;
}());
// var flag:number = 0;
// while(flag === 1){
var value = 2;
var obj = new buyProduct();
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
