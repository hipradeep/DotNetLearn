using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.prectice
{
    class Language : ABC
    {
        static void Main(string[] args)
        {
            Language l = new Language();
            l.display1();
            l.display2();
            Language l1 = new Language(22);
            l1.display1();
            l1.display2();

            Console.ReadLine();
        }
        public override void display1()
        {
            Console.WriteLine("ABC");
        }
        public Language():base(21)
        {
           
            Console.WriteLine("Language Constructor");
        }
        public Language(int d)
        {
           
            Console.WriteLine("Language Constructor "+d);
        }
    }

    abstract class ABC
    {

        // abstract method
        public abstract void display1();

        // non-abstract method
        public void display2()
        {
            Console.WriteLine("Non abstract method");
        }

        public ABC()
        {
            Console.WriteLine("ABC Constructor");
        }
        public ABC(int a)
        {
            Console.WriteLine("ABC Constructor "+a);
        }
    }
}
