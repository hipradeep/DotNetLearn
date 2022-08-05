using System;

namespace DotNetLearn.prectice
{
    class NumSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a number!");

            do
            {
                char c = Console.ReadLine()[0];

                if (c == 'y' || c == 'Y')
                {
                    break;
                }
                else
                {
                    if (Char.IsDigit(c))
                    {
                        // int m = Convert.ToInt32(c);
                        int m = c - '0';
                        sum = sum + m;
                        Console.WriteLine("ReEnter-");
                    }
                    else
                    {
                        Console.WriteLine("To exit, please enter Y");
                        Console.WriteLine("or ReEnter-");
                    }
                }

            } while (true);
            Console.WriteLine("Sum of entered numbers - " + sum);
            Console.ReadLine();


        }
    }
}
