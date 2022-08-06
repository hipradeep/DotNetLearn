using System;

namespace DotNetLearn.assignments.lab_3
{
    class Q2ArrayRev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of number");
            int n = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter value at index " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entred Array");

            foreach (int a in arr)
            {
                Console.Write(a+" ");
            }

            Console.WriteLine("\nReverse Array");

            for (int i = n-1; i >=0; i--)
            {
                Console.Write(arr[i]+" ");
            }

            Console.ReadLine();
        }
    }
}
