using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_4
{
    class MainClass
    {
        static void Main(string[] args)
        {
           // System.Reflection.MemberInfo info = typeof(Student);
            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            //object[] attributes = info.GetCustomAttributes(true);

            foreach (var item in types)
            {
                Console.WriteLine("Class : {0}", item.Name);
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
                System.Console.WriteLine("hi");
            Console.ReadKey();

        }
    }

  public  class Student
    {
        private int roolno;
        private string name;
        private int mark1;
        private int mark2;

        public double AverageMarkes(double m1, double m2)
        {
            return (double)(m1 + m2) / 2;
        }

    }
}
