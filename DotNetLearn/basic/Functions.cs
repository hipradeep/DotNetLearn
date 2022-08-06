using System;

namespace DotNetLearn.basic
{
    class Functions
    {
        static void Main(string[] arg)
        {

            int a ;
            int sum;
            int mul;

            // method(a);
            //   method_ref(ref a);
            //  Console.WriteLine(a);

            method_out(10, 20, out sum, out mul);
            Console.WriteLine("Sum - "+sum);
            Console.WriteLine("Mul - " + mul);
            Console.ReadLine();
        }

        private static void method_out(int a, int b, out int sum, out int mul)
        {
            sum = a + b;
            mul = a * b;
            
        }

        private static void method_ref(ref int a)
        {
            a = a * 4;
            Console.WriteLine(a);
        }

        private static void method(int a)
        {
            Console.WriteLine(a);
        }
    }
}
