using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q7SquareSum
    {
        static void Main(string[] args)
        {
            int count = 1;
            int sum = 0;
            do
            {
                if (count % 2 == 0)
                {
                    sum = sum +count*count;
                }
                count++;

            } while (count <=20);

            Console.WriteLine("Sum of Square of first 10 number - " + sum);

            Console.ReadLine();
        }
    }
}
