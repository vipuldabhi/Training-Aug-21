using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class PracticeDay2
    {
    }

    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }


        public Employee(int age, string name, double salary, DateTime startingdate, string phonenumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            StartingDate = startingdate;
            PhoneNumber = phonenumber;
        }
    }

    class operation
    {
        int a, b;
        public void add()
        {

        }
    }


    class Class1
    {
        public int addition(int num1, int num2)
        {
            int result;
            result = num1 + num2;
            return result;
        }
        public int subtraction(int num1, int num2)
        {
            int result;
            result = num1 - num2;
            return result;
        }
        public int multiplication(int num1, int num2)
        {
            int result;
            result = num1 * num2;
            return result;
        }
        public int division(int num1, int num2)
        {
            int result;
            result = num1 / num2;
            return result;
        }

        static void Main(string[] args)
        {
            //Employee dav = new Employee();
            //dav.Age = 30;
            //Console.WriteLine(dav.Age); 

            //Employee dav = new Employee()
            //{
            //    Age = 30,
            //    Salary = 50000
            //};
            //Console.WriteLine($"dav's Age is {dav.Age} And Salary is {dav.Salary}");

            //Employee construct = new Employee(23, "john", 5000.00, new DateTime(2021, 2, 22), "9876546789");
            //Console.WriteLine("{0}'s age is {1} salary is {2}",construct.Name,construct.Age,construct.Salary);


            Class1 operation = new Class1();

            int a, b;
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());

            int result = operation.addition(a, b);
            Console.WriteLine("Result is :" + result);
            Console.ReadLine();
        }
    }
}
