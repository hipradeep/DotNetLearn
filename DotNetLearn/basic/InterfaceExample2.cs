using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.basic
{
    class InterfaceExample2
    {
        //explicite example of interface
        private static void Main(string[] args)
        {
            RunExam re = new RunExam();
            ((I1)re).method();
            ((I2)re).method();
            Console.ReadLine();

        }
    }
    class RunExam : I1, I2
    {
        void I1.method()
        {
            Console.WriteLine("Interface 1 Method");
        }
        void I2.method()
        {
            Console.WriteLine("Interface 2 Method");
        }
    }
    interface I1
    {
        void method();
    }
    interface I2
    {
        void method();
    }
}
