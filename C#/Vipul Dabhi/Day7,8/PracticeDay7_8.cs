using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //var primes = new List<int> { 2, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23 };

            //var result = from val in primes
            //                where val > 13
            //                    select val;
            //foreach (var val in result)
            //{
            //    Console.WriteLine(val);
            //}

            //var result2 = primes.Where(x => x < 13);
            //foreach (var val in result2)
            //{
            //    Console.WriteLine(val);
            //}



            //OfType


            //List<object> mixedList = new List<object>();
            //mixedList.Add(0);
            //mixedList.Add("One");
            //mixedList.Add("Two");
            //mixedList.Add(3);

            //var stringResult = from s in mixedList.OfType<string>()
            //                   select s;
            //var intResult = from s in mixedList.OfType<int>()
            //                select s;

            //foreach(var i in stringResult)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (var i in intResult)
            //{
            //    Console.WriteLine(i);
            //}
            //MethodAccessException syntax : var stringResult = mixedList.OfType<string>();


            //OrderBy


            //List<int> IntList = new List<int>();

            //IntList.Add(7);
            //IntList.Add(6);
            //IntList.Add(3);
            //IntList.Add(4);
            //IntList.Add(5);

            //var result = from val in IntList
            //             orderby val
            //             select val;
            //var result = IntList.OrderBy(i => i);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}


            //ThenBy

            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
            //    new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            //};
            //var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            //var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);


            //GroupBy/ToLookup


            //var groupedResult = from s in studentList
            //                    group s by s.Age;

            ////iterate each group        
            //foreach (var ageGroup in groupedResult)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

            //    foreach (Student s in ageGroup) // Each group has inner collection
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}
            //Method : var groupedResult = studentList.GroupBy(s => s.Age);

            //var lookupResult = studentList.ToLookup(s => s.age);
            //foreach (var group in lookupResult)
            //{
            //    Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 

            //    foreach (Student s in group)  //Each group has a inner collection  
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}


            //Join

            IList<string> strList1 = new List<string>() {
                "One",
                "Two",
                "Three",
                "Four"
            };

            IList<string> strList2 = new List<string>() {
                "One",
                "Two",
                "Three",
                "Six"
            };

            var innerJoin = strList1.Join(strList2,
                                  str1 => str1,
                                  str2 => str2,
                                  (str1, str2) => str1);
            foreach (var str in innerJoin)
            {
                Console.WriteLine("{0} ", str);
            }


            //select


            //IList<Student> studentList = new List<Student>() {
            //new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            //new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            //new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            //new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            //};
            //// returns collection of anonymous objects with Name and Age property
            //var selectResult = from s in studentList
            //                   select new { Name = "Mr. " + s.StudentName, Age = s.Age };
            //// iterate selectResult
            //foreach (var item in selectResult)
            //    Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);
            //Output:
            //Student Name: Mr.John, Age: 13
            //Student Name: Mr.Moin, Age: 21
            //Student Name: Mr.Bill, Age: 18
            //Student Name: Mr.Ram, Age: 20
            //Student Name: Mr.Ron, Age: 15
            //Method:
            //var selectResult = studentList.Select(s => new {
            //    Name = s.StudentName,
            //    Age = s.Age
            //});


            //All/any/


            //bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
            //Console.WriteLine(areAllStudentsTeenAger);

            //bool isAnyStudentTeenAger = studentList.Any(s => s.age > 12 && s.age < 20);


            //Contains

            //IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            //bool result = intList.Contains(10);  // returns false

            //Student std = new Student() { StudentID = 3, StudentName = "Bill" };
            //bool result = studentList.Contains(std, new StudentComparer()); //returns true


            //Agregrate

            //IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
            //var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            //Console.WriteLine(commaSeperatedString);


            //Average

            //var avgAge = studentList.Average(s => s.Age);
            //Console.WriteLine("Average Age of Student: {0}", avgAge);


            //Single,SingleOrDefault



            //IList<int> oneElementList = new List<int>() { 7 };
            //IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            //IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            //IList<string> emptyList = new List<string>();

            //Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            //Console.WriteLine("The only element in oneElementList: {0}",
            //             oneElementList.Single());

            //Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

            //Console.WriteLine("The only element which is less than 10 in intList: {0}",
            //             intList.Single(i => i < 10));

            ////Followings throw an exception
            ////Console.WriteLine("The only Element in intList: {0}", intList.Single());
            ////Console.WriteLine("The only Element in intList: {0}", intList.SingleOrDefault());
            ////Console.WriteLine("The only Element in emptyList: {0}", emptyList.Single());



            //DefaultIfEmpty


            //IList<Student> emptyStudentList = new List<Student>();
            //var newStudentList1 = studentList.DefaultIfEmpty(new Student());
            //var newStudentList2 = studentList.DefaultIfEmpty(new Student()
            //{
            //    StudentID = 0,
            //    StudentName = ""
            //});
            //Console.WriteLine("Count: {0} ", newStudentList1.Count());
            //Console.WriteLine("Student ID: {0} ", newStudentList1.ElementAt(0));
            //Console.WriteLine("Count: {0} ", newStudentList2.Count());
            //Console.WriteLine("Student ID: {0} ", newStudentList2.ElementAt(0).StudentID);



            //Union


            //IList<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
            //IList<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };
            //var result = strList1.Union(strList2);
            //foreach (string str in result)
            //    Console.WriteLine(str);


            //Intersect


            //IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            //IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            //var result = strList1.Intersect(strList2);
            //foreach (string str in result)
            //    Console.WriteLine(str);



            //Except


            //IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            //IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            //var result = strList1.Except(strList2);
            //foreach (string str in result)
            //    Console.WriteLine(str);


            //Differed


            //IList<Student> studentList = new List<Student>() {
            //new Student() { StudentID = 1, StudentName = "John", age = 13 } ,
            //new Student() { StudentID = 2, StudentName = "Steve",  age = 15 } ,
            //new Student() { StudentID = 3, StudentName = "Bill",  age = 18 } ,
            //new Student() { StudentID = 4, StudentName = "Ram" , age = 12 } ,
            //new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
            //};
            //var teenAgerStudents = from s in studentList.GetTeenAgerStudents()
            //                       select s;
            //foreach (Student teenStudent in teenAgerStudents)
            //    Console.WriteLine("Student Name: {0}", teenStudent.StudentName);


            //Immediate


            //IList<Student> teenAgerStudents =
            //    studentList.Where(s => s.age > 12 && s.age < 20).ToList();

            //IList<Student> teenAgerStudents = (from s in studentList
            //                                   where s.age > 12 && s.age < 20
            //                                   select s).ToList();


            //let


            //var lowercaseStudentNames = from s in studentList
            //                            let lowercaseStudentName = s.StudentName.ToLower()
            //                            where lowercaseStudentName.StartsWith("r")
            //                            select lowercaseStudentName;

            //foreach (var name in lowercaseStudentNames)
            //    Console.WriteLine(name);


            //into


            //var teenAgerStudents = from s in studentList
            //                       where s.age > 12 && s.age < 20
            //                       select s
            //                            into teenStudents
            //                            where teenStudents.StudentName.StartsWith("B")
            //                            select teenStudents;

                                       

            Console.ReadLine();
        }
    }
}
