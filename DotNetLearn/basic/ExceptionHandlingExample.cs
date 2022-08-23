using System;

namespace DotNetLearn.basic
{
    class ExceptionHandlingExample
    {

        static void Main(string[] arg)
        {
            try
            {
                int a = 0;
                int b = 0;
                // int x = a / b;

                if (a <= 0 && b <= 0)
                {
                    throw new Exception("Both is less then Zero");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finlly");
            }
        

            Console.ReadLine();
        }
    }
}
