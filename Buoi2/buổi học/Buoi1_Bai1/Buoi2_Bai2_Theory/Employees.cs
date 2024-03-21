using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Bai2_Theory
{
    /// <summary>
    /// Tạo lớp đối tượng Employees
    /// Tạo các thuộc tính tự động
    ///     Id, FullName, Salary
    /// Tạo phương thức PrintInfor
    ///     hiển thị thông tin nhân viên
    /// - Test trong Main của program.cs
    /// </summary>
    internal class Employees
    {
        // properties
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Salary { get; set; }
        // Method
        public void PrintInfor()
        {
            Console.WriteLine("Id\t: " + Id);
            Console.WriteLine("FullName: " + FullName);
            Console.WriteLine("Salary\t: " + Salary);
        }
    }
}
