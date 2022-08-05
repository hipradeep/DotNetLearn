using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_1
{
    class Q1920Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number !");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number !");
            int s = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("First   - " + f);
            Console.WriteLine("Second   - " + s);


            swap(f, s);
            swapWithoutThird(f, s);

            Console.ReadLine();

        }

        private static void swap(int f, int s)
        {

            Console.WriteLine("Using Thirsd variable ");

            int t = f;
            f = s;
            s = t;

            Console.WriteLine("First   - " + f);
            Console.WriteLine("Second   - " + s);

        }
        private static void swapWithoutThird(int f, int s)
        {
            Console.WriteLine("Using without third variable ");
            f = f + s;
            s = f - s;
            f = f - s;

            Console.WriteLine("First   - " + f);
            Console.WriteLine("Second   - " + s);

        }
    }
}
