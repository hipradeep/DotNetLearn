using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.basic
{
    class GenericType
    {
        static void Main(string[] args)
        {
            MyClas<int, string> obj = new MyClas<int, string>();
            obj.property = 100;
            obj.behaver(100, "pradeep");
            Console.ReadLine();
        }
    }

    class MyClas<T1, T2>
    {
        public T1 property { get; set; }
        public void behaver(T1 p, T2 q)
        {
            Console.WriteLine(p + "  " + q);
        }
    }
}
