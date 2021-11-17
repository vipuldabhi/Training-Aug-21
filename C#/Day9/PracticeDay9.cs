using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Day9
{
    class PracticeDay9
    {
    }

    public static class XX
    {
        public static void NewMethod(this extensionmethods ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();

            //extensionmethods ob = new extensionmethods();
            //string display = ob.Display();
            //string print = ob.Print();
            //ob.NewMethod();

            //Console.WriteLine(display);
            //Console.WriteLine(print);


            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("method1");
            });
        }


        public static void Method2()
        {
            Thread.Sleep(3000);
            Console.WriteLine("method2");
        }

    }
}
