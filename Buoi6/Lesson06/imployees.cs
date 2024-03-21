using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    internal class imployees
    {
        //properties/ attribute
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpPhone { get; set; }
        public double EmpSalary { get; set; }
        // Contructor
        public imployees() { }
        public imployees(int empID, string empName, string phone, double empSalary)
        {
            EmpID = empID;
            EmpName = empName;
            EmpPhone = phone;
            EmpSalary = empSalary;
        }
        // method
        public override string ToString()
        {
            return string.Format("{0,-5}{1,-15}{2,-15}{3:#,##0.##}",EmpID,EmpName,EmpPhone,EmpSalary);
        }
    }
}
