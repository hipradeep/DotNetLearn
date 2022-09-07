using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.prectice
{
    class Arrays
    {
        public static void Main(string[] args)
        {
            //int[] arr = new int[5];
            //  int arr[] = new int[5];
            //int [] arr = new int[5];
            //arr[0] = 10;
            //arr[1] = 10;
            //arr[2] = 22;
            //arr[3] = 10;
            //arr[4] = 20;


            //foreach (int a in arr)
            //{
            //    Console.WriteLine(a);
            //}

            int[,] numbers = { { 2, 3 }, { 4, 5 } };

            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);
            Console.WriteLine("Element at index [0, 0] : " + numbers[0,0]);
            Console.ReadLine();
        }
    }
}
