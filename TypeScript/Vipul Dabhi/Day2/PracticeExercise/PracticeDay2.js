// Tuple
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
function bookDetails(books) {
    console.log("Book Id is " + books.id + "Book title is" + books.title);
}
var mybook = {
    id: 1,
    title: "ege",
    author: "dgd",
    available: true,
    year: "1212"
};
var mybook1 = {
    id: 1,
    title: "ege",
    author: "dgd",
    available: true
};
bookDetails(mybook);
var demoFunction;
demoFunction = function () { return console.log("hello world"); };
//   printCoord({ x: 100, y: 100 });
// Classes
// class Greeter {
//     greeting: string;
//     constructor(message: string) {
//       this.greeting = message;
//     }
//     greet() {
//       return "Hello, " + this.greeting;
//     }
//   }
//   let greeter = new Greeter("world");
// //   extend
//   class Animal {
//     move(distanceInMeters: number = 0) {
//       console.log(`Animal moved ${distanceInMeters}m.`);
//     }
//   }
//   class Dog extends Animal {
//     bark() {
//       console.log("Woof! Woof!");
//     }
//   }
//   const dog = new Dog();
//   dog.bark();
//   dog.move(10);
//   dog.bark();
// overide Method
var Base = /** @class */ (function () {
    function Base() {
    }
    Base.prototype.greet = function () {
        console.log("Hello, world!");
    };
    return Base;
}());
var Derived = /** @class */ (function (_super) {
    __extends(Derived, _super);
    function Derived() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Derived.prototype.greet = function (name) {
        if (name === undefined) {
            _super.prototype.greet.call(this);
        }
        else {
            console.log("Hello, ".concat(name.toUpperCase()));
        }
    };
    return Derived;
}(Base));
var d = new Derived();
d.greet();
d.greet("reader");
