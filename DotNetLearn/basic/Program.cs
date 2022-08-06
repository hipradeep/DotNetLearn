using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // step();
            // step1();
            step2();

        }
        static void step2()
        {
            Console.WriteLine("First Number - ");
            //int fn = Convert.ToInt32( Console.ReadLine());
            long fn = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Second Number - ");
            int sn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum - " + (fn + sn));
            Console.WriteLine("Sum -  {0}", (fn + sn));
            Console.ReadLine();

        }
        static void step1()
        {
            Console.WriteLine("First Name - ");
            var fName = Console.ReadLine();

            Console.WriteLine("Last Name - ");
            var lName = Console.ReadLine();

            Console.WriteLine("First Name - " + fName + " \nLast Name - " + lName);
            Console.ReadLine();
        }
        static void step()
        {
            int value = 101;
            int a = 200, b = 201;
            method2();
            callByValue(100);
            callByRef(ref value);
            callByOut(out a, out b);
            Console.WriteLine("Out a - " + a + "Out b - " + b);

            Program1 p1 = new Program1();
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
                p1.method();
                Console.ReadLine();
            }
        }

        static void method2()
        {
            Console.WriteLine("Method2");
        }

        static void callByValue(int a)
        {
            Console.WriteLine("Call By Value");
            Console.WriteLine("Value - " + a);
        }
        static void callByRef(ref int a)
        {
            Console.WriteLine("Call By Reference");
            Console.WriteLine("Value - " + a);
        }
        static void callByOut(out int x, out int y)
        {

            Console.WriteLine("Call By OUT");
            x = 5;
            y = 5;

            Console.WriteLine("Value x - " + x);
            Console.WriteLine("Value y - " + x);
        }
    }
    class Program1
    {
        public void method()
        {
            Console.WriteLine("Method");

        }
    }
}
