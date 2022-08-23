using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn.basic
{
    class Properties
    {
        static void Main(string[] args)
        {


            Student s = new Student();
            s.ID = 101;
            s.Name = "Mahesh";
            Console.WriteLine("Student ID = {0}", s.ID);
            Console.WriteLine("Student Name = {0}", s.Name);
            Console.WriteLine("Student Pass Marks = {0}", s.PassMark);

            Console.ReadKey();
        }
    }
    class demo
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        //public int ID { get => _ID; set => _ID = value; }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private int _PassMark = 35;

        public int PassMark
        {
            get { return _PassMark; }

        }
    }

    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMark = 35;


        public int PassMark
        {
            get
            {
                return this._PassMark;
            }
        }


        public int ID
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student ID can not be negative or zero");
                }
                this._ID = value;

            }

            get
            {
                return this._ID;
            }
        }


        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can not be null or blank.");
                }
                this._Name = value;

            }

            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No name is provided" : this._Name;
            }
        }



    }
}
