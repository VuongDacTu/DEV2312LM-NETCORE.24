using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    internal class Rectangle : Shape
    {
        public void InputData()
        {
            Console.WriteLine("Nhap chieu dai:");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong:");
            width = int.Parse(Console.ReadLine());

        }
        public override float Area()
        {
            return length * width;
        }
        public override float Circumference()
        {
            return (length + width) * 2;
        }

    }
}
