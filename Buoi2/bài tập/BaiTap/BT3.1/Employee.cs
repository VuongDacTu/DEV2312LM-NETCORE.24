using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._1
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary { get; set; }
        public Employee() { }
        public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicLevel)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicLevel;
        }
        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }
        public void Display()
        {
            Console.WriteLine("id:\t\t" + id);
            Console.WriteLine("name:\t\t" +  name);
            Console.WriteLine("yearOfBirth:\t" + yearOfBirth);
            Console.WriteLine("basicSalary:\t" + basicSalary);
            Console.WriteLine("income:\t\t" + GetIncome());
        }

    }

}
