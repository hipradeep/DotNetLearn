using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.basic
{
    class InterfaceExample

    {
        private static void Main(string[] args)
        {

            Rectangle r1 = new Rectangle();
            Name n1 = new Name();

            r1.calculateArea(100, 200);
            r1.getColor();
            n1.getColor();
            n1.getName();

            Console.ReadLine();

        }
    }
    class Name : IBase
    {
        public void getColor()
        {
            Console.WriteLine("Green Color");
        }

        public void getName()
        {

            Console.WriteLine("NAME");

        }
    }

    class Rectangle : IPolygon, IColor
    {

        // implementation of methods inside interface
        public void calculateArea(int l, int b)
        {

            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        public void calculateArea()
        {
            throw new NotImplementedException();
        }

        // implementation of IColor interface
        public void getColor()
        {

            Console.WriteLine("Red Rectangle");

        }
    }
    interface IPolygon
    {
        // method without body
        void calculateArea();
    }
    interface IColor
    {

        void getColor();
    }

    interface IBase : IColor
    {
        void getColor();
        void getName();
    }

}
