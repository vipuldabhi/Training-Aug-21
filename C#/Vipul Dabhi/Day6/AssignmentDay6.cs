using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class AssignmentDay6
    {
        public double calculateArea(double x, double y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            //1.Compute area of rectangle using func delegate

            AssignmentDay6 obj = new AssignmentDay6();

            Console.WriteLine("Enter a :");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b :");
            double b = Convert.ToDouble(Console.ReadLine());


            Func<double, double, double> area = obj.calculateArea;

            double result = area(a, b);
            Console.WriteLine("Area Of Rectengle is :" + result);



            //2.Compute add of two number using lambda expression


            Func<int, int, int> add = (x,y) => x + y;

            int z = add(2, 4);

            Console.WriteLine(z);


            Console.ReadLine();
        }

        


    }
}
