using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    internal class Student
    {
        // properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        // Contructor
        public Student() 
        {
            ID = 0;
            Name = "";
            Age = 0;
        }
        public Student(int ID, string Name, int Age) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
        //Method
        public void Display()
        {
            Console.WriteLine("ID:\t" + ID);
            Console.WriteLine("Name:\t" +  Name);
            Console.WriteLine("Age:\t" + Age);

        }
    }
}
