using System;

namespace DotNetLearn.assignments.lab_3
{
    class Q6_3DArray
    {
        static void Main(string[] args)
        {

            int[,,] arr = new int[2, 2, 2] {  { {1, 2 },{ 3,4} }, { {5,6 },{7,8 } }, };

            Console.Write("Array----");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine("\nValue of arr[" + i + "," + j + ","+k+"] = " + arr[i, j, k]);
                    }

                }
            }
            Console.ReadLine();

        }
    }
}
