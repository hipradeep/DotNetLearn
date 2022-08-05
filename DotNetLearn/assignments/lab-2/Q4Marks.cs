using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q4Marks
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Enter marks of Sub-{0} ", (count+1));
                int m = Convert.ToInt32(Console.ReadLine());
                sum = sum + m;
                count++;
               
            } while (count < 5);

            Console.WriteLine("Mark Percentage is - " + (sum / 5f));

            Console.ReadLine();
        }
    }
}
