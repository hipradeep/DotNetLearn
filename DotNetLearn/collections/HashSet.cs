using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.collections
{
    //It does not store duplicate elements.
    class HashSet
    {
        public static void Main(string[] args)
        {
            // Create a set of strings  
            //var names = new HashSet<string>();
            var names = new HashSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan" };
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added  

            // Iterate HashSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
