using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    abstract class Student
    {
        protected string Name;
        protected int year;
        public Student (string name, int year)
        {
            this.Name = name;
            this.year = year;
        }
        protected void Display()
        {
            Console.WriteLine("Name:\t" + Name);
            Console.WriteLine("Year:\t" + year);
        }

        public abstract double Average();
    }
}
