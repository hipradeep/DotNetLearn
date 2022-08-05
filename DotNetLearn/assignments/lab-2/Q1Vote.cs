using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q1Vote
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age - ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {

                Console.WriteLine("You are eligible for vote");
            }
            else
            {
                Console.WriteLine("You are not eligible for vote");
            }

            Console.ReadLine();
        }
    }
}
