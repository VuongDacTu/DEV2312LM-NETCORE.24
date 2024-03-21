using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_01Theory
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student() { }
        public Student(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
        public void Display()
        {
            Console.WriteLine("ID:\t" + ID);
            Console.WriteLine("Ten:\t" + Name);
            Console.WriteLine("Age:\t" + Age);

        }

        public override string ToString()
        {
            return string.Format("{0,-5} {1,-15} {2,-10}", ID,Name,Age);
        }

    }
}
