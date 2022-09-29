using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.assignments.lab_5
{
    class LabQuestion1
    {
        static void Main(string[] arg)
        {
            Rectangle r = new Rectangle(12, 12);
        
            r.displayArea();

        }

    }

    abstract class Shape
    {
     

        private  string color;
        public string Color   // property
        {
            get { return color; }   // get method
            set { color = value; }  // set method
        }
        public abstract double Area();

    }
    class Rectangle : Shape
    {
        private int Length;
        private int Width;

        public Rectangle(int l, int w)
        {
            Length = l;
            Width = w;
        }

        public override double Area()
        {
            return Length * Width ;
        }
        public  void displayArea()
        {
            Console.WriteLine("Area is" + this.Area());
            Console.ReadLine();
        }
    }



}
