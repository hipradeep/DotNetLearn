using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_1
{
    class Q5MultiplicationInt
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number!");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number!");

            int b = Convert.ToInt32(Console.ReadLine());


            int s = a * b;

            Console.WriteLine("Multiplication Is - " + s);
            Console.ReadLine();

        }
    }
}
