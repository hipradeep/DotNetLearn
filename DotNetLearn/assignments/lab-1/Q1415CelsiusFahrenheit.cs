using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_1
{
    class Q1415CelsiusFahrenheit
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number !");
            int a = Convert.ToInt32(Console.ReadLine());

            convertInFahrenheit(a);
            convertInCelsius(a);

            Console.ReadLine();
        }

        private static void convertInCelsius(int a)
        {
            Console.WriteLine("let temperature in Fahrenheit is -  " + a);
            double c = (((a-32)*5)/9);

            Console.WriteLine("temperature in Celsius is - " + c);
        }

        private static void convertInFahrenheit(int a)
        {
              Console.WriteLine("let temperature in Celsius is -  " + a);


            double f = a *(9/5) + 32;

            Console.WriteLine("temperature in Fahrenheit is - " + f);
        }
    }
}
