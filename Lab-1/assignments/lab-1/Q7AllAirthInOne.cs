using System;

namespace Lab_1
{
    class Q7AllAirthInOne
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice!");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number!");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number!");

            int b = Convert.ToInt32(Console.ReadLine());
            switch (c)

            {
                case 1:
                    sum(a, b);
                    break;
                case 2:
                    sub(a, b);
                    break;
                case 3:
                    mul(a, b);
                    break;
                case 4:
                    div(a, b);
                    break;
                default:
                    Console.WriteLine("Wrong Choice!");
                    Console.ReadLine();
                    break;

            }

        }

        static void sum(int a, int b)
        {
            Console.WriteLine("Addition Is - " + (a + b));
            Console.ReadLine();
        }
        static void sub(int a, int b)
        {
            Console.WriteLine("Subtraction Is - " + (a - b));
            Console.ReadLine();
        }
        static void mul(int a, int b)
        {
            Console.WriteLine("Multiplication Is - " + (a * b));
            Console.ReadLine();
        }
        static void div(int a, int b)
        {
            Console.WriteLine("Division Is - " + (a / b));
            Console.ReadLine();
        }


    }
}
