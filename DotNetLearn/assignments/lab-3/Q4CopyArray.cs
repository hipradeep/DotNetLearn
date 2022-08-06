using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_3
{
    class Q4CopyArray
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            int[] arr2 = new int[arr.Length];

            for (int i= 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
                arr2[i] = arr[i];
            }

            Console.WriteLine("\nCoped Array");
            foreach (int a in arr2)
            {
                Console.Write(a+" ");
            }

            Console.ReadLine();


        }
    }
}
