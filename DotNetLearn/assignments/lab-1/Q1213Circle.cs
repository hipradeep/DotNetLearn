using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Q1213Circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius !");
            int a = Convert.ToInt32(Console.ReadLine());

         

            areaOfCircle(a);
            perimeterOfCircle(a);

            Console.ReadLine();

        }
        private static void perimeterOfCircle(int a)
        {
            double area = Math.PI*a*a;

            Console.WriteLine("Perimeter Is - " + area);
        }

        private static void areaOfCircle(int a)
        {

            double p =2*Math.PI*a;

            Console.WriteLine("Area Is - " + p);
        }
    }
}
