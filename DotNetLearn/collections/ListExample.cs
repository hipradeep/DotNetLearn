using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.collections
{
    //It store duplicate elements.
    class ListExample
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            //var names = new List<string>();
            var names = new List<string>() { "Sonoo", "Vimal", "Ratan", "Love" };
            names.Add("Sonoo Jaiswal");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
