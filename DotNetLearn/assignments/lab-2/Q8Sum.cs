using System;

namespace DotNetLearn.assignments.lab_2
{
    class Q8Sum
    {
        static void Main(string[] args)
        {
            int count = 1;
            float sum = 0;
            do
            {
           
                sum = sum + (1f / count);
                count = count + 3;

            } while (count <= 25);

            Console.WriteLine("Sum  - " + sum);

            Console.ReadLine();
        }
    }
}
