using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q9Ascii
    {
        static void Main(string[] args)
        {
            int count = 65;
            
            do
            {
                Console.WriteLine("ASCII character of " + count+" - "+(char)count);
                count = count + 1;

            } while (count <= 90);

            Console.ReadLine();
        }
    }
}
