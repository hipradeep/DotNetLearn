using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Q1011Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length !");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width  !");

            int b = Convert.ToInt32(Console.ReadLine());

            areaOfRectangle(a, b);
            perimeterOfRectangle(a, b);
            
            Console.ReadLine();

        }

        private static void perimeterOfRectangle(int a, int b)
        {
            int area = 2*(a + b);

            Console.WriteLine("Perimeter Is - " + area);
        }

        private static void areaOfRectangle(int a, int b)
        {
          
            int area = a * b;

            Console.WriteLine("Area Is - " + area);
        }
    }
}
