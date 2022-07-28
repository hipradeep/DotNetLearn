using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Q9Average

    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number!");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number!");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number!");

            int c = Convert.ToInt32(Console.ReadLine());


            int s = (a +b+ c)/3;

            Console.WriteLine("Avarage Is - " + s);
            Console.ReadLine();

        }
    }
}
