//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day1
//{

//    class AssignmentDay1
//    {
//        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

//        static void Main(string[] args)
//        {
//            //1.Print sum of all the even numbers
//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            int sum = 0;
//            foreach (int i in numbers)
//            {
//                if (i % 2 == 0)
//                {
//                    sum += i;
//                }
//                else
//                {
//                    continue;
//                }
//            }
//            Console.WriteLine(sum);

//            //2.Store your name in one string and find out how many vowel characters are
//            //there in your name.

//            string myName = "Vipul";
//            int noOfVowelChar = 0;
//            foreach (char i in myName)
//            {
//                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
//                {
//                    noOfVowelChar = noOfVowelChar + 1;
//                }
//            }
//            Console.WriteLine(noOfVowelChar);

//            //3.Create a weekday enum and accept week day number and display week day.

//            int dayNum = (int)Days.Thursday;

//            switch (dayNum)
//            {
//                case 1:
//                    Console.WriteLine("Monday");
//                    break;
//                case 2:
//                    Console.WriteLine("Tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;
//                case 4:
//                    Console.WriteLine("Thursday");
//                    break;
//                case 5:
//                    Console.WriteLine("Friday");
//                    break;
//                case 6:
//                    Console.WriteLine("Saturday");
//                    break;
//                case 7:
//                    Console.WriteLine("Sunday");
//                    break;
//                default:
//                    Console.WriteLine("Please select a valid day num!!!");
//                    break;
//            }

//            //4.Accept 10 student Name,Address,Hindi,English,Maths Marks ,
//            //do the total and compute Grade. Note do it with Array and display the result in grid format

//            string name, address;
//            int hindimarks, englishmarks, mathsmarks;
//            Student[] studata = new Student[10];
//            for (int i = 0; i < studata.Length; i++)
//            {
//                Console.WriteLine("Enter Name of student :");
//                name = Console.ReadLine();
//                Console.WriteLine("Enter Address of student :");
//                address = Console.ReadLine();
//                Console.WriteLine("Enter marks of hindi subject out of 100 :");
//                hindimarks = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter marks of english subject out of 100 :");
//                englishmarks = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter marks of maths subject out of 100 :");
//                mathsmarks = Convert.ToInt32(Console.ReadLine());
//                studata[i] = new Student(name, address, hindimarks, englishmarks, mathsmarks);
//            }
//            Console.WriteLine("Name|Address|Hindi|English|Maths|Total Marks|Percentage|Grade");
//            for (int i = 0; i < studata.Length; i++)
//            {
//                studata[i].display();
//            }
//            Console.ReadKey();

//            //5.Accept Age from user, if age is more than 18 eligible for vote otherwise it should be displayed as
//            //not eligible. Do it with ternary operator

//            int age;
//            Console.Write("Enter Your Age : ");
//            age = int.Parse(Console.ReadLine());

//            string result = age > 18 ? "Eligible For Vote" : "Not Eligible";
//            Console.WriteLine(result);

//        }

//    }

//    class Student
//    {
//        string name, address, grade;
//        float percentage;
//        int hindimarks, englishmarks, mathsmarks, total;
//        public Student(string name, string address, int hindimarks, int englishmarks, int mathsmarks)
//        {
//            this.name = name;
//            this.address = address;
//            this.hindimarks = hindimarks;
//            this.englishmarks = englishmarks;
//            this.mathsmarks = mathsmarks;
//            total = hindimarks + englishmarks + mathsmarks;
//            percentage = total / 3;
//            if (percentage > 90)
//            {
//                grade = "A+";
//            }
//            else if (percentage > 80 & percentage <= 90)
//            {
//                grade = "A";
//            }
//            else if (percentage > 70 & percentage <= 80)
//            {
//                grade = "B+";
//            }
//            else if (percentage > 55 & percentage <= 70)
//            {
//                grade = "B";
//            }
//            else if (percentage > 40 & percentage <= 55)
//            {
//                grade = "C";
//            }
//            else if (percentage > 35 & percentage <= 40)
//            {
//                grade = "D";
//            }
//            else
//            {
//                grade = "F";
//            }
//        }
//        public void display()
//        {
//            Console.WriteLine("------------------------------------------------------------");
//            Console.WriteLine($"{name}|{address}|{hindimarks}|{englishmarks}|{mathsmarks}|{total}|{percentage}|{grade}");
//        }


//        static void Main(string[] args)
//        {

//        }

//    }
//}
