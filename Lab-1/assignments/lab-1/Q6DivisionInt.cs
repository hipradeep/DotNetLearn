using System;

namespace Lab_1
{

    class Q6DivisionInt
    {



        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number!");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number!");

            int b = Convert.ToInt32(Console.ReadLine());


            int s = a / b;

            Console.WriteLine("Division Is - " + s);
            Console.ReadLine();

        }
    }
}
