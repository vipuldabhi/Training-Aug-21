
// // Numbers

// let first:number = 123; // number 
// let second: number = 0x37CF;  // hexadecimal
// let third:number=0o377 ;      // octal
// let fourth: number = 0b111001;// binary  

// console.log(first);  // 123 
// console.log(second); // 14287
// console.log(third);  // 255
// console.log(fourth); // 57 

// // toExponential()

// let myNumber: number = 123456;

// myNumber.toExponential(); // returns 1.23456e+5
// myNumber.toExponential(1); //returns 1.2e+5
// myNumber.toExponential(2); //returns 1.23e+5
// myNumber.toExponential(3); //returns 1.235e+5

// // toFixed()

// let myNumber: number = 10.8788;

// myNumber.toFixed(); // returns 11
// myNumber.toFixed(1); //returns 10.9
// myNumber.toFixed(2); //returns 10.88
// myNumber.toFixed(3); //returns 10.879
// myNumber.toFixed(4); //returns 10.8788

// // toLocaleString()

// let myNumber: number = 10667.987;

// myNumber.toLocaleString(); // returns 10,667.987 - US English
// myNumber.toLocaleString('de-DE'); // returns 10.667,987 - German
// myNumber.toLocaleString('ar-EG'); // returns 10667.987 in Arebic

// // toPrecision()

// let myNumber: number = 10.5679;

// myNumber.toPrecision(1); // returns 1e+1
// myNumber.toPrecision(2); // returns 11
// myNumber.toPrecision(3); // returns 10.6
// myNumber.toPrecision(4); // returns 10.57

// // toString()

// let myNumber: number = 123;
// myNumber.toString(); // returns '123'
// myNumber.toString(2); // returns '1111011'
// myNumber.toString(4); // returns '1323'
// myNumber.toString(8); // returns '173'
// myNumber.toString(16); // returns '7b'
// myNumber.toString(36); // returns '3f'

// // valueOf()

// let myNumber = new Number(123);
// console.log(myNumber) //Output: a number object with value 123
// console.log(myNumber.valueOf()) //Output: 123
// console.log(typeof num) //Output: object

// let num2 = num.valueOf() 
// console.log(num2) //Output: 123
// console.log(typeof num2) //Output: number


// String

// let employeeName:string = 'John Smith'; 
// //OR
// let employeeName:string = "John Smith"; 

// Template String


// let employeeName:string = "John Smith"; 
// let employeeDept:string = "Finance"; 
// // Pre-ES6 
// let employeeDesc1: string = employeeName + " works in the " + employeeDept + " department."; 
// // Post-ES6 
// let employeeDesc2: string = `${employeeName} works in the ${employeeDept} department.`; 
// console.log(employeeDesc1);//John Smith works in the Finance department. 
// console.log(employeeDesc2);//John Smith works in the Finance department. 

// charAt()

// let str: string = 'Hello TypeScript';
// str.charAt(0); // returns 'H'
// str.charAt(2); // returns 'l'
// "Hello World".charAt(2); returns 'l'

// concat()


// let str1: string = 'Hello';
// let str2: string = 'TypeScript';
// str1.concat(str2); // returns 'HelloTypeScript'
// str1.concat(' ', str2); // returns 'Hello TypeScript'
// str1.concat(' Mr. ', 'Bond'); // returns 'Hello Mr. Bond'

// indexOf()

// let str: string = 'TypeScript';

// str.indexOf('T'); // returns 0
// str.indexOf('p'); // returns 2
// str.indexOf('e'); // returns 3
// str.indexOf('T', 1); // returns -1
// str.indexOf('t', 1); // returns 9

// replace()

// let str1: string = 'Hello Javascript';
// let str2: string = 'TypeScript';

// str1.replace('Java', 'Type'); // returns 'Hello TypeScript'
// str1.replace('JavaScript', str2); // returns 'Hello TypeScript'
// str1.replace(/Hello/gi, 'Hi'); // returns 'Hi TypeScript'

// split()

// let str1: string = 'Apple, Banana, Orange';
// let str2: string = ',';

// str1.split(str2) // returns [ 'Apple', ' Banana', ' Orange' ]
// str1.split(',') // returns [ 'Apple', ' Banana', ' Orange' ]
// str1.split(',', 2) // returns [ 'Apple', ' Banana' ]
// str1.split(',', 1) // returns [ 'Apple']

// toUpperCase()

// let str: string = 'Hello Typescript';
// str.toUpperCase(); // returns 'HELLO TYPESCRIPT'
// 'hello typescript'.toUpperCase(); // returns 'HELLO TYPESCRIPT'

// toLowerCase()

// let str: string = 'Hello Typescript';
// str.toLowerCase(); // returns hello typescript
// 'HELLO TYPESCRIPT'.toLowerCase(); // returns hello typescript

// Any

// let something: any = "Hello World!"; 
// something = 23;
// something = true;

// let arr: any[] = ["John", 212, true]; 
// arr.push("Smith"); 
// console.log(arr); //Output: [ 'John', 212, true, 'Smith' ] 


// Arrays

// let fruits: Array<string>;
// fruits = ['Apple', 'Orange', 'Banana']; 

// let ids: Array<number>;
// ids = [23, 34, 100, 124, 44]; 

// let values: (string | number)[] = ['Apple', 2, 'Orange', 3, 4, 'Banana']; 
// // or 
// let values: Array<string | number> = ['Apple', 2, 'Orange', 3, 4, 'Banana']; 

// let fruits: string[] = ['Apple', 'Orange', 'Banana']; 
// fruits[0]; // returns Apple
// fruits[1]; // returns Orange
// fruits[2]; // returns Banana
// fruits[3]; // returns undefined

// Access array element

// let fruits: string[] = ['Apple', 'Orange', 'Banana']; 

// for(var index in fruits)
// { 
//     console.log(fruits[index]);  // output: Apple Orange Banana
// }

// for(var i = 0; i < fruits.length; i++)
// { 
//     console.log(fruits[i]); // output: Apple Orange Banana
// }

// Array Methods

var fruits: Array<string> = ['Apple', 'Orange', 'Banana']; 
fruits.sort(); 
console.log(fruits); //output: [ 'Apple', 'Banana', 'Orange' ]

console.log(fruits.pop()); //output: Orange

fruits.push('Papaya'); 
console.log(fruits); //output: ['Apple', 'Banana', 'Papaya']

fruits = fruits.concat(['Fig', 'Mango']); 
console.log(fruits); //output: ['Apple', 'Banana', 'Papaya', 'Fig', 'Mango'] 

console.log(fruits.indexOf('Papaya'));//output: 2