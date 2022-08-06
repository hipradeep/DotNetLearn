using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_3
{
    class Q3SumOfArray
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Enter length of number");
            int n = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter value at index " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entred Array");
          

            foreach (int a in arr)
            {
                Console.Write(a + " ");
                sum = sum + a;
            }

            Console.WriteLine("\nSum of Array - "+sum);

            Console.ReadLine();
        }
    }
}
