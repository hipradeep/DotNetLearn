using System;

namespace Lab_1
{
    class Q17SquareCube
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number !");
            int n = Convert.ToInt32(Console.ReadLine());

            int s = n * n;

            Console.WriteLine("Square  - " + s);
            int c = n * n * n;
            Console.WriteLine("Cube  - " + c);
            Console.ReadLine();

        }
    }
}
