using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q5OddSum
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            do
            {
               if(count % 2 != 0)
                {
                    Console.WriteLine("" + count);
                    sum = sum + count;
                }
               
                count++;

            } while (count < 20);

            Console.WriteLine("Sum Of Odd Numbers - " + sum);

            Console.ReadLine();
        }
    }
}
