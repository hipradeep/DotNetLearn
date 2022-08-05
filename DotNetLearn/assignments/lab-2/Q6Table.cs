using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q6Table
    {
        static void Main(string[] args)
        {
            int count = 1;
        
            Console.WriteLine("Multiplication table of a number");
            Console.WriteLine("Enter number ");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(count+"X"+n+" = "+ (count*n));
                count++;

            } while (count <= 10);
            Console.ReadLine();
        }
    }
}
