using System;

namespace DotNetLearn.assignments.lab_3
{
    class Q7JaggedArray
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter the size of array at index " + i + " in jagged array! - ");
                int k = Convert.ToInt32(Console.ReadLine());
                arr[i]= new int[k];

                for (int j = 0; j < k; j++)
                {
                    Console.Write("Enter the value of arr[" + i + "][" + j + "] - ");
                     arr[i][j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }


            Console.Write("Array----");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {

                    Console.WriteLine("\nValue of arr[" + i + "," + j + "] = " + arr[i][j]);

                }
            }
            Console.ReadLine();

        }
    }
}
