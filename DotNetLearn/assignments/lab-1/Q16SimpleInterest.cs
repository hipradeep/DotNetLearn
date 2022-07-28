using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Q16SimpleInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter principle amount !");
            int p= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate !");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter year !");
            int m = Convert.ToInt32(Console.ReadLine());

            double si = p * r * m;
            Console.WriteLine("Simple Inerest Is - " + si);
            Console.ReadLine();

        }
    }
}
