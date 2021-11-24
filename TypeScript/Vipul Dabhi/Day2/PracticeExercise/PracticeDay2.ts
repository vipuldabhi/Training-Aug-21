
// Tuple

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


interface Book{
  id:number;
  title:string;
  author:string;
  available:boolean;

}

function bookDetails(books:Book) {
    console.log("Book Id is "+books.id+"Book title is" + books.title);

}

var mybook = {
  id:1,
  title:"ege",
  author:"dgd",
  available:true,
  year:"1212"
}

var mybook1 : Book = {
  id:1,
  title:"ege",
  author:"dgd",
  available:true,
}

bookDetails(mybook);


// function type interface

interface fun{
  (str : string) : void;
}

var demoFunction : fun;
demoFunction = () => console.log("hello world");



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

class Base {
    greet() {
      console.log("Hello, world!");
    }
  }
   
  class Derived extends Base {
    greet(name?: string) {
      if (name === undefined) {
        super.greet();
      } else {
        console.log(`Hello, ${name.toUpperCase()}`);
      }
    }
  }
   
  const d = new Derived();
  d.greet();
  d.greet("reader");