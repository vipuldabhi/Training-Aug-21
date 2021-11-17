using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class PracticeDay6
    {
        static void Main(string[] args)
        {
            // Declare a Func variable and assign a lambda expression to the
            // variable. The method takes a string and converts it to uppercase.
            Func<string, string> selector = str => str.ToUpper();
            // Create an array of strings.
            string[] words = { "orange", "apple", "Article", "elephant" };
            // Query the array and select strings according to the selector method.
            IEnumerable<String> aWords = words.Select(selector);
            // Output the results to the console.
            foreach (String word in aWords)
                Console.WriteLine(word);
            /*
            This code example produces the following output:
            ORANGE
            APPLE
            ARTICLE
            ELEPHANT
            */


            //// Instantiate delegate to reference UppercaseString method
            //ConvertMethod convertMeth = UppercaseString;
            //string name = "Dakota";
            //// Use delegate instance to call UppercaseString method
            //Console.WriteLine(convertMeth(name));

            //// Instantiate delegate to reference UppercaseString method
            //Func<string, string> convertMethod = UppercaseString;
            //string name = "Dakota";
            //// Use delegate instance to call UppercaseString method
            //Console.WriteLine(convertMethod(name));
            //string UppercaseString(string inputString)
            //{
            //    return inputString.ToUpper();
            //}
            //// This code example produces the following output:
            ////
            ////    DAKOTA
            



        }
        private static string UppercaseString(string inputString)
        {
            return inputString.ToUpper();
        }
    }

    //event example

    //public delegate string MyDel(string str);
    //class EventProgram
    //{
    //    event MyDel MyEvent;
    //    public EventProgram()
    //    {
    //        this.MyEvent += new MyDel(this.WelcomeUser);
    //    }
    //    public string WelcomeUser(string username)
    //    {
    //        return "Welcome " + username;
    //    }
    //    static void Main(string[] args)
    //    {
    //        EventProgram obj1 = new EventProgram();
    //        string result = obj1.MyEvent("Tutorials Point");
    //        Console.WriteLine(result);
    //    }
    //}
}
