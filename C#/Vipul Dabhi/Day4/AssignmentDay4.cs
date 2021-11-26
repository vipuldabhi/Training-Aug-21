using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day4
{
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        { }
    }

    public class NameException : Exception
    {
        public NameException(string message) : base(message) 
        { }
    }

    public class DateException : Exception
    {
        public DateException(string message) : base(message)
        { }
    }

    class Student
    {
        public void checkAge(int age)
        {
            if (age < 0)
            {
                throw new AgeException("Age is must be greater than 0 !!!");
            }
            else
            {
                Console.WriteLine("Valid Age !!!!");
            }
        }

        public void checkName(string name)
        {
            if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Valid Name.");
            }
            else
            {
                throw new NameException("Invalid Name , Name Only Contain Character.");
            }
        }

        public void checkDate(DateTime date)
        {
            DateTime currentDate = DateTime.Now;
            int result = DateTime.Compare(date, currentDate);

            if (result < 0)
                throw new DateException("First date is earlier");
            else
                Console.WriteLine("Correct Date.");

        }
    }

    class AssignmentDay4
    {
        static void Main(string[] args)
        {
            //1. Create a user defined Exception Class AgeException. If Age is less than 0
            // it should be thrown an exception.And you need to handle that exception in student class.

            //try
            //{
            //    Student student = new Student();
            //    Console.WriteLine("Enter Age :");
            //    int Age = Convert.ToInt32(Console.ReadLine());
            //    student.checkAge(Age);
            //}
            //catch (AgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NameException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //2.Create a user defined exception class NameException which will validate a
            //Name and name should contain only character.If name does not contain proper value
            //it should throw an exception.You need to handle exception in student class.

            //try
            //{
            //    Student student2 = new Student();
            //    Console.WriteLine("Enter Name :");
            //    string Name =Console.ReadLine();
            //    student2.checkName(Name);
            //}
            //catch (NameException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //3.Create a user defined Exception DateException class which will validate 
            //date should not be less than the current date.If date is less than current date 
            //it should throw an exception.

            try
            {
                Student student3 = new Student();
                Console.WriteLine("Enter Date :");
                string dateString = Console.ReadLine();
                DateTime Date =
                    DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
                student3.checkDate(Date);
            }
            catch (DateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }

}
