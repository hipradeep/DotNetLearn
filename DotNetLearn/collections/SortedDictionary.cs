using System;
using System.Collections.Generic;

namespace DotNetLearn.collections
{
    // It contains unique keys and maintains ascending order on the basis of key. B
    class SortedDictionary
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("4", "Peter");
            names.Add("5", "James");
            names.Add("3", "Ratan");
            names.Add("2", "Irfan");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.ReadLine();
        }
    }
}
