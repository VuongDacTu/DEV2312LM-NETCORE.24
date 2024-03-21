using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle:Shape
    {
        public void InputData()
        {
            Console.WriteLine("Nhap chieu dai:");
            length = int .Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong:");
            width = int .Parse(Console.ReadLine());

        }
        public override float Area()
        {
           return length*width;
        }
        public override float Circumference()
        {
            return (length+width)*2;
        }

    }
}
