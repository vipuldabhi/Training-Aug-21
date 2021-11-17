//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day3
//{
//    class Program
//    {
//        class Vehicle  // Base class
//        {
//            public string brand = "Ford";  // Vehicle field
//            public void honk()             // Vehicle method 
//            {
//                Console.WriteLine("Tuut, tuut!");
//            }
//        }

//        class Car : Vehicle  // Derived class
//        {
//            public string modelName = "Mustang";  // Car field
//        }

//        //Polymorphism

//        class Animal  // Base class (parent) 
//        {
//            public virtual void animalSound()
//            {
//                Console.WriteLine("The animal makes a sound");
//            }
//        }

//        class Pig : Animal  // Derived class (child) 
//        {
//            public override void animalSound()
//            {
//                Console.WriteLine("The pig says: wee wee");
//            }
//        }

//        class Dog : Animal  // Derived class (child) 
//        {
//            public override void animalSound()
//            {
//                Console.WriteLine("The dog says: bow wow");
//            }
//        }

//        //Abstraction

//        // Abstract class
//        abstract class Animal
//        {
//            // Abstract method (does not have a body)
//            public abstract void animalSound();
//            // Regular method
//            public void sleep()
//            {
//                Console.WriteLine("Zzz");
//            }
//        }

//        // Derived class (inherit from Animal)
//        class Pig : Animal
//        {
//            public override void animalSound()
//            {
//                // The body of animalSound() is provided here
//                Console.WriteLine("The pig says: wee wee");
//            }
//        }


//        Interface


//         Interface
//interface IAnimal
//        {
//            void animalSound(); // interface method (does not have a body)
//        }

//        // Pig "implements" the IAnimal interface
//        class Pig : IAnimal
//        {
//            public void animalSound()
//            {
//                // The body of animalSound() is provided here
//                Console.WriteLine("The pig says: wee wee");
//            }
//        }



//        static void Main(string[] args)
//        {

//            //Inheritance

//            // Create a myCar object
//            Car myCar = new Car();

//            // Call the honk() method (From the Vehicle class) on the myCar object
//            myCar.honk();

//            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
//            Console.WriteLine(myCar.brand + " " + myCar.modelName);


//            //Polymorphism

//            Animal myAnimal = new Animal();  // Create a Animal object
//            Animal myPig = new Pig();  // Create a Pig object
//            Animal myDog = new Dog();  // Create a Dog object

//            myAnimal.animalSound();
//            myPig.animalSound();
//            myDog.animalSound();


//            //Abstraction

//            Pig myPig = new Pig();  // Create a Pig object
//            myPig.animalSound();
//            myPig.sleep();

//            Interface

//            Pig myPig = new Pig();  // Create a Pig object
//            myPig.animalSound();

//        }
//    }
//}

