using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.basic
{
    class InharitanceExample
    {
        static void Main(string[] ag)
        {
            Abc a = new Abc();

            a.address = "pk";
        }
    }
   public class Abc : Xyz
    {
      public  int position;
       public string name;
        public Abc()
        {
            Console.WriteLine("abc");
        }
    }
   public class Xyz
    {
        int price;
        public string address;
        public Xyz()
        {
            Console.WriteLine("Xyz");
        }
    }
}
