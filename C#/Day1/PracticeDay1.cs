using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstFriend = "Maria";
            //string secondFriend = "Sage";
            //Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            //Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            //Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


            //string greeting = "      Hello World!       ";
            //Console.WriteLine($"[{greeting}]");

            //string trimmedGreeting = greeting.TrimStart();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //trimmedGreeting = greeting.TrimEnd();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //trimmedGreeting = greeting.Trim();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //string sayHello = "Hello World!";
            //Console.WriteLine(sayHello);
            //sayHello = sayHello.Replace("llo", "Greetings");
            //Console.WriteLine(sayHello);

            //Console.WriteLine(sayHello.ToUpper());
            //Console.WriteLine(sayHello.ToLower());

            // Data Types in C#

            //int myNum = 5;               // integer (whole number)
            //double myDoubleNum = 5.99D;  // floating point number
            //char myLetter = 'D';         // character
            //bool myBool = true;          // boolean
            //string myText = "Hello";     // string
            //Console.WriteLine(myNum);
            //Console.WriteLine(myDoubleNum);
            //Console.WriteLine(myLetter);
            //Console.WriteLine(myBool);
            //Console.WriteLine(myText);

            // Type Casting

            //int myInt = 9;
            //double myDouble = myInt;  // Automatic casting: int to double
            //Console.WriteLine(myInt);
            //Console.WriteLine(myDouble);


            //double myDouble = 9.78;
            //int myInt = (int)myDouble;  // Manual casting: double to int
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myInt);

            //int myInt = 10;
            //double myDouble = 5.25;
            //bool myBool = true;
            //Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
            //Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
            //Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
            //Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string

            // Variables

            // Syntax
            // type variableName = value;

            //string name = "John";
            //Console.WriteLine(name);

            //int myNum = 15;
            //Console.WriteLine(myNum);

            //int myNum;
            //myNum = 15;
            //Console.WriteLine(myNum);

            //int myNum = 15;
            //myNum = 20; // myNum is now 20
            //Console.WriteLine(myNum);

            //const int myNum = 15;
            //myNum = 20; // error

            //string firstName = "John ";
            //string lastName = "Doe";
            //string fullName = firstName + lastName;
            //Console.WriteLine(fullName);

            //int x = 5;
            //int y = 6;
            //Console.WriteLine(x + y); // Print the value of x + y

            //int x = 5, y = 6, z = 50;
            //Console.WriteLine(x + y + z);



            // Arrays


            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            //int[] myNum = { 10, 20, 30, 40 };

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Console.WriteLine(cars[0]);
            //// Outputs Volvo

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //cars[0] = "Opel";
            //Console.WriteLine(cars[0]);
            //// Now outputs Opel instead of Volvo

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Console.WriteLine(cars.Length);
            //// Outputs 4

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            // The foreach Loop

            // Syntax
            // foreach (type variableName in arrayName) 
            // {
            //   // code block to be executed
            // }

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}

            // Sort Arrays

            // Sort a string
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Array.Sort(cars);
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}
            //// Sort an int
            //int[] myNumbers = { 5, 1, 8, 9 };
            //Array.Sort(myNumbers);
            //foreach (int i in myNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            // System.Linq Namespace

            //int[] myNumbers = { 5, 1, 8, 9 };
            //Console.WriteLine(myNumbers.Max());  // returns the largest value
            //Console.WriteLine(myNumbers.Min());  // returns the smallest value
            //Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            //// Other Ways to Create an Array

            //// Create an array of four elements, and add values later
            //string[] cars = new string[4];
            //// Create an array of four elements and add values right away 
            //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            //// Create an array of four elements without specifying the size 
            //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            //// Create an array of four elements, omitting the new keyword, and without specifying the size
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            //// Declare an array
            //string[] cars;
            //// Add values, using new
            //cars = new string[] { "Volvo", "BMW", "Ford" };
            //// Add values without using new (this will cause an error)
            //cars = { "Volvo", "BMW", "Ford"};



            // C# If ... Else


            // Syntax
            // if (condition1)
            // {
            //   // block of code to be executed if condition1 is True
            // } 
            // else if (condition2) 
            // {
            //   // block of code to be executed if the condition1 is false and condition2 is True
            // } 
            // else
            // {
            //   // block of code to be executed if the condition1 is false and condition2 is False
            // }

            //int time = 22;
            //if (time < 10)
            //{
            //    Console.WriteLine("Good morning.");
            //}
            //else if (time < 20)
            //{
            //    Console.WriteLine("Good day.");
            //}
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}
            // Outputs "Good evening."

            // Short Hand If...Else (Ternary Operator)

            //int time = 20;
            //if (time < 18)
            //{
            //    Console.WriteLine("Good day.");
            //}
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}

            //int time = 20;
            //string result = (time < 18) ? "Good day." : "Good evening.";
            //Console.WriteLine(result);



            // C# Switch Statements


            // Syntax
            // switch(expression) 
            // {
            //   case x:
            //     // code block
            //     break;
            //   case y:
            //     // code block
            //     break;
            //   default:
            //     // code block
            //     break;
            // }

            //int day = 4;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //}
            // Outputs "Thursday" (day 4)

            //int day = 4;
            //switch (day)
            //{
            //    case 6:
            //        Console.WriteLine("Today is Saturday.");
            //        break;
            //    case 7:
            //        Console.WriteLine("Today is Sunday.");
            //        break;
            //    default:
            //        Console.WriteLine("Looking forward to the Weekend.");
            //        break;
            //}
            // Outputs "Looking forward to the Weekend."


            // C# Operators


            //int sum1 = 100 + 50;        // 150 (100 + 50)
            //int sum2 = sum1 + 250;      // 400 (150 + 250)
            //int sum3 = sum2 + sum2;     // 800 (400 + 400)


            // enum


            // enum Months
            // {
            //   January,    // 0
            //   February,   // 1
            //   March=6,    // 6
            //   April,      // 7
            //   May,        // 8
            //   June,       // 9
            //   July        // 10
            // }

            // static void Main(string[] args)
            // {
            //   int myNum = (int) Months.April;
            //   Console.WriteLine(myNum);
            // }

            // enum Level 
            // {
            //   Low,
            //   Medium,
            //   High
            // }
            // You can access enum items with the dot syntax:

            // Level myVar = Level.Medium;
            // Console.WriteLine(myVar);


        }
    }
}
