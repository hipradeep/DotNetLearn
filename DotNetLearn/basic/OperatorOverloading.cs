using System;

namespace DotNetLearn.basic
{
    class OperatorOverloading
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(2, 4) + new Complex(3, 4);
            c.toString();

            Console.ReadLine();

        }

    }

    class Complex
    {
        int x;
        int y;
        public Complex(int a, int b)
        {
            x = a;
            y = b;
        }
        public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex(c1.x + c2.x, c1.y + c2.y);
        }

        public void toString()
        {
            Console.WriteLine(x+"+i"+y);
        }
    }
}
