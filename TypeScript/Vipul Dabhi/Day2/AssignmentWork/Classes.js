"use strict";
exports.__esModule = true;
exports.buyProduct = void 0;
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
exports.buyProduct = buyProduct;
