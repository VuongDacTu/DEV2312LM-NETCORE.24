using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    internal class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public double Avg { get; set; }
        public override string ToString()
        {
            return string.Format("\n ID: {0},\nFullName: {1}, \nLastName: {2}," +
                "\nGender: {3}, Average mark: {4}", Id, FirstName,LastName,(Gender?"Male":"Female"),Avg);
        }
    }
}
