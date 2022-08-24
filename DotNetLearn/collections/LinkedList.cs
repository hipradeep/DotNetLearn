using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.collections
{
    class LinkedList
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //insert new element before "Peter"  
            LinkedListNode<String> node = names.Find("Peter");
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
