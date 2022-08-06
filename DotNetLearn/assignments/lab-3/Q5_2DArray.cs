using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_3
{
    class Q5_2DArray
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[3,3];

            for(int i=0; i<3; i++)
            {
                for(int j=0; j< 3; j++)
                {
                    Console.Write("Enter the value of arr[" + i + "][" + j + "] - ");
                    arr[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Array----");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\nValue of arr[" + i + "][" + j + "] = "+arr[i,j]);
                    
                }
            }
            Console.ReadLine();
        }
    }
}
