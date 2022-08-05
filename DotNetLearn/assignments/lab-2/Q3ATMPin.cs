using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q3ATMPin
    {
        static void Main(string[] args)
        {

            int correctPin = 1234;
            int pin = 0;
            do
            {
                Console.WriteLine("Enter ATM pin - ");
                 pin = Convert.ToInt32(Console.ReadLine());
                if(correctPin == pin)
                {
                    Console.WriteLine("Correct ATM pin");
                }
                else
                {
                    Console.WriteLine("You enter wrong ATM pin");
                }

            } while (correctPin != pin);
           

            



            Console.ReadLine();
        }
    }
}
