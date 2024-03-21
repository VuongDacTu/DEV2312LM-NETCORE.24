using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson03_Theory
{
    internal class Staff:Person
    {
        public float Salary { get; set; }
        // kế thừa constructor
        public Staff() { }
        public Staff(int id, string name, string address, string phone,float salary, float baseSalary) :base( id,  name,  address,  phone, baseSalary) 
        {
            this.Salary = salary;
        }
        public void prinInfo()
        {
            //Console.WriteLine("ID:\t" + Id);
            //Console.WriteLine("name:\t" + Name);
            //Console.WriteLine("address:\t" + Address);
            //Console.WriteLine("Phone:\t" + Phone);
            base.prinInfo();
            Console.WriteLine("Salary:\t" + Salary);
        }
        // ghi đè phương thức Overriding (polymorphism)
        public override float GetSalary()
        {
            return base.GetSalary() + Salary;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("| " + GetSalary());
        }
    }
}
