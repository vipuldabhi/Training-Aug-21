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
// var employee: [number, string] = [1, "Steve"];
// var person: [number, string, boolean] = [1, "Steve", true];
// var user: [number, string, boolean, number, string];// declare tuple variable
// user = [1, "Steve", true, 20, "Admin"];// initialize tuple variable
// Array Of Tuple
// var employee: [number, string][];
// employee = [[1, "Steve"], [2, "Bill"], [3, "Jeff"]];
// Add element into tuple
// var employee: [number, string] = [1, "Steve"];
// employee.push(2, "Bill"); 
// console.log(employee); //Output: [1, 'Steve', 2, 'Bill']
// Use Array Methos
// var employee: [number, string] = [1, "Steve"];
// // retrieving value by index and performing an operation 
// employee[1] = employee[1].concat(" Jobs"); 
// console.log(employee); //Output: [1, 'Steve Jobs']
// Enum
// There are three types of enums:
// Numeric enum
// String enum
// Heterogeneous enum
// enum PrintMedia {
//     Newspaper,
//     Newsletter,
//     Magazine,
//     Book
//   }
//   Newspaper = 0
//   Newsletter = 1
//   Magazine = 2
//   Book = 3
//   enum PrintMedia {
//     Newspaper = 1,
//     Newsletter = 5,
//     Magazine = 5,
//     Book = 10
// }
// Enum as return type
// enum PrintMedia {
//     Newspaper = 1,
//     Newsletter,
//     Magazine,
//     Book
// }
// function getMedia(mediaName: string): PrintMedia {
//     if (  mediaName === 'Forbes' || mediaName === 'Outlook') {
//         return PrintMedia.Magazine;
//     }
//  }
// let mediaType: PrintMedia = getMedia('Forbes'); // returns Magazine
// Union
// function printId(id: number | string) {
//     console.log("Your ID is: " + id);
//   }
//   // OK
//   printId(101);
//   // OK
//   printId("202");
//   // Error
//   printId({ myID: 22342 });
//   Argument of type '{ myID: number; }' is not assignable to parameter of type 'string | number'.
//     Type '{ myID: number; }' is not assignable to type 'number'.
// Working with Union Types
// function printId(id: number | string) {
//     console.log(id.toUpperCase()); // Not Valid
//   }
// Way of using it
// function printId(id: number | string) {
//     if (typeof id === "string") {
//       // In this branch, id is of type 'string'
//       console.log(id.toUpperCase());
//     } else {
//       // Here, id is of type 'number'
//       console.log(id);
//     }
//   }
// function welcomePeople(x: string[] | string) {
//     if (Array.isArray(x)) {
//       // Here: 'x' is 'string[]'
//       console.log("Hello, " + x.join(" and "));
//     } else {
//       // Here: 'x' is 'string'
//       console.log("Welcome lone traveler " + x);
//     }
//   }
// Interface
// interface Point {
//     x: number;
//     y: number;
//   }
//   function printCoord(pt: Point) {
//     console.log("The coordinate's x value is " + pt.x);
//     console.log("The coordinate's y value is " + pt.y);
//   }
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
