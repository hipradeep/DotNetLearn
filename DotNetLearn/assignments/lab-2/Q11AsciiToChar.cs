using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q11AsciiToChar
    {
        static void Main(string[] args)
        {
            int count = 97;
            
            do
            {
                Console.WriteLine("ASCII character  of " + count + " - " + (char)count);
                count = count + 1;

            } while (count <= 122);

            Console.ReadLine();
        }
    }
}
