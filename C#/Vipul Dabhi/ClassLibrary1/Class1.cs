using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public DateTime DateOfBirth;
        string adult;
        string sunsign;
        string chinisesign;
        string username;
        string birthDayOrNot;


        public Person(string firstname, string lastname, string emailaddress, DateTime dateofbirth)
        {
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = emailaddress;
            DateOfBirth = dateofbirth;
        }
        public Person(string firstname, string lastname, string emailaddress)
        {
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = emailaddress;
        }
        public Person(string firstname, string lastname, DateTime dateofbirth)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
        }

        public void calculate()
        {
            int age = 0;
            age = DateTime.Now.Subtract(DateOfBirth).Days;
            age = age / 365;

            if (age > 18)
            {
                adult = "You are Adult";
            }
            else
            {
                adult = "You are Not Adult";
            }

            //sunsugn

            int month = DateOfBirth.Month;
            int day = DateOfBirth.Day;
            //string sunsign;

            if (((month == 1) && (day >= 21 || day <= 31)) || ((month == 2) && (day >= 01 || day <= 20)))
            {
                sunsign = "Aires";

            }
            if (((month == 2) && (day >= 21 || day <= 31)) || ((month == 3) && (day >= 01 || day <= 20)))
            {
                sunsign = "Aires";

            }

            if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 01 || day <= 20)))
            {
                sunsign = "Aires";

            }
            if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 01 || day <= 21)))
            {
                sunsign = "Taurus";
            }
            if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 01 || day <= 21)))
            {
                sunsign = "Gemini";
            }
            if (((month == 6) && (day >= 22 || day <= 31)) || ((month == 7) && (day >= 01 || day <= 22)))
            {
                sunsign = "Cancer";
            }
            if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 01 || day <= 22)))
            {
                sunsign = "leo";
            }
            if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 01 || day <= 21)))
            {
                sunsign = "Virgo";
            }


            //chinisesign

            int year = DateOfBirth.Year;
            //string chinisesign;

            if (year % 12 == 0)
            {
                chinisesign = "Monkey";
            }
            //Now I'm going to place all the other zodiacs like you said, yay!
            else if (year % 12 == 1)
            {
                chinisesign = "Rooster";
            }
            else if (year % 12 == 2)
            {
                chinisesign = "Dog";
            }
            else if (year % 12 == 3)
            {
                chinisesign = "Pig";
            }
            else if (year % 12 == 4)
            {
                chinisesign = "Rat";
            }
            else if (year % 12 == 5)
            {
                chinisesign = "Ox";
            }
            else if (year % 12 == 6)
            {
                chinisesign = "Tiger";
            }
            else if (year % 12 == 7)
            {
                chinisesign = "Rabbit";
            }
            else if (year % 12 == 8)
            {
                chinisesign = "Dragon";
            }
            else if (year % 12 == 9)
            {
                chinisesign = "Snake";
            }
            else if (year % 12 == 10)
            {
                chinisesign = "Horse";
            }
            else
            {
                chinisesign = "Sheep";
            }

            //BirthDayOrNot

            if (DateOfBirth == DateTime.Now.Date)
            {
                birthDayOrNot = "yes";
            }
            else
            {
                birthDayOrNot = "no";
            }


            //Username

            username = FirstName + "@" + LastName ;
        }

        public string Adult
        {
            get
            {
                return adult;
            }
        }

        public string Sunsign
        {
            get
            {
                return sunsign;
            }
        }

        public string Chinisesign
        {
            get
            {
                return chinisesign;
            }
        }

        public string BirthDayOrNot
        {
            get
            {
                return birthDayOrNot;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
        }



    }
}
