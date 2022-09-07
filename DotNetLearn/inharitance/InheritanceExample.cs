using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.inharitance
{
    class InheritanceExample
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            Console.ReadLine();
        }
    }

    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("I eat food");
        }
        public Animal()
        {
            Console.WriteLine("Animal");
        }
    }
    // derived class of Animal 
    class Dog : Animal
    {

        // overriding method from Animal
        public override void eat() 
        {
            base.eat();
            Console.WriteLine("I eat Dog food");
        }
        public Dog()
        {
            Console.WriteLine("Dog");
        }
    }
}
