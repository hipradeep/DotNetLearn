using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q2LeapYear
    {
        static void Main(string[] args)
        {

            //1900 not leap, 2016
            Console.WriteLine("Enter year - ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(y%4==0 & y%100 != 0)
            {
                Console.WriteLine("Leap Year");
            }
            else if(y % 400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }

            Console.ReadLine();
        }

    }
}
