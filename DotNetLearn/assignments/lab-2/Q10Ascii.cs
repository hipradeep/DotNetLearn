using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q10Ascii
    {
        static void Main(string[] args)
        {
            int count = 48;
            
            do
            {
                Console.WriteLine("ASCII character of " + count + " - " + (char)count);
                count = count + 1;

            } while (count <= 57);

            Console.ReadLine();
        }
    }
}
