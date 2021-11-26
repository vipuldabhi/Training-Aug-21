using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class PracticeExerciseDay5
    {
        static void Main(string[] args)
        {


            //1. Create a list which will store 5 student names and then display it search it index number



            //List<string> li = new List<string>();

            //li.Add("John");
            //li.Add("Neena");
            //li.Add("Mehul");
            //li.Add("Sheetal");
            //li.Add("Neha");

            //foreach (string i in li)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(li.IndexOf(i));

            //}



            //2.Create a stack which will store Age of person and display it last in first out order.


            //Stack<int> age = new Stack<int>();

            //age.Push(21);
            //age.Push(22);
            //age.Push(23);
            //age.Push(24);
            //age.Push(25);

            //foreach(int i in age)
            //{
            //    Console.WriteLine(i);
            //}



            //3.Store a product information in map object.Key will be a product item and
            //value will be the price of that product. Search the product by product name.


            Dictionary<string, int> map = new Dictionary<string, int>();

            map.Add("Chocalate", 80);
            map.Add("Buscuit", 20);
            map.Add("Colddrink", 45);
            map.Add("Snacks", 10);

            Console.WriteLine(map["Chocalate"]);



            Console.ReadLine();
        }
    }
}
