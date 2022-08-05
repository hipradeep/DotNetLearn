using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_2
{
    class Q12Pattern1
    {
        static void Main(string[] args)
        {
           

            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" "+j );
                }
                Console.WriteLine( "");
            }

           
            Console.WriteLine("----------------------------------");

            for (int i = 1; i <= 4; i++)
            {
                int k = i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + k);
                    k = k + (4 - j);
                }
               
                Console.WriteLine("");
            }


            Console.ReadLine();
        }
      

    }
}
