using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public float baseSalary { get; set; }
        public Person() { }
        public Person(int id, string name, string address, string phone, float baseSalary)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            this.baseSalary = baseSalary;
        }
        public void prinInfo()
        {
            Console.WriteLine("ID:\t" + Id);
            Console.WriteLine("name:\t" + Name);
            Console.WriteLine("address:" + Address);
            Console.WriteLine("Phone:\t" + Phone);
        }

        // phương thức cho phép ghi đè
        public virtual float GetSalary()
        {
            return baseSalary;
        }
        public override string ToString()
        {
            return String.Format("{0} | {1} | {2} | {3} | {4}", Id, Name, Address, Phone, baseSalary);
        }
    }
}
