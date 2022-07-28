using System;

namespace Lab_1
{
    class Q22Digit
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Enter a  number!");
            int n = Convert.ToInt32(Console.ReadLine());

            int s = 0, r=0, count=0, f=0,n1=0;
            int first = 0;
            int sec = 0;
            int third = 0;
            int fourth = 0;

            while (n != 0)
            {
                s = s + n % 10;
                if (count == 0)
                {
                    f = n % 10;
                    first = n % 10; //first digit
                    n1 = n / 10;
                }
                if (count == 1) sec = n % 10;  // second digit

                if (count == 2) third = n % 10;  //third digit

                if (count == 3) fourth = n % 10;  //third digit

                r = r * 10 + n % 10;
                n = n / 10;

                count = count + 1;

                if (n != 0) f = f * 10;

                else n1 = n1 + f;
            }

                Console.WriteLine("Digit Sum " + s);
                Console.WriteLine("Revers Order " + r);
                Console.WriteLine("Last At first " + n1);
                Console.WriteLine("Second At Third  " + fourth + "" + sec + "" + third + "" + first);

                Console.ReadLine();
            }

            
        }
    }
