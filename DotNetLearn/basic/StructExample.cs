using System;

namespace DotNetLearn.basic
{


    public struct Books
    {
        int price;
        string aName;
        public Books(int p, string n)
        {
            price = p;
            aName = n;
        }
        public int totalPrice(int c)
        {
            return c * price;
        }
    }
    class StructExample
    {
        static void Main(string[] args)
        {
            Books b = new Books(120, "pradeep");
           int tp= b.totalPrice(5);


            //Console.WriteLine("Author Name - " + b.aName);
            //Console.WriteLine(" Price - " +b.price);

            Console.WriteLine("Total Price - "+tp);


            DateTime dt = new DateTime(2015, 12, 31);
            Console.WriteLine("Date- " + dt.Date);

            Console.ReadLine();

        }
    }
}
