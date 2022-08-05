using System;

namespace DotNetLearn.assignments.lab_1
{
    class Q2223Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name!");

            string name = Console.ReadLine();
            Console.WriteLine("Welcome "+name);

            Console.WriteLine("Enter age!");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phone!");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter email!");
            string email = Console.ReadLine();

            Console.WriteLine("Enter address!");
            string address = Console.ReadLine();

       

            Console.WriteLine("Employee - Name: " + name+" Age: "+age+" Phone: "+phone+" Email: "+email+" Address: "+address);



            Console.ReadLine();
        }
    }
}
