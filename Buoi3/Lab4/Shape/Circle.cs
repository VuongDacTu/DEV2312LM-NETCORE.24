using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle:Shape
    {

        public void InputData()
        {
            Console.WriteLine("Nhap ban kinh: ");
            radius = int.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return 3.14f * radius * radius;
        }
        public override float Circumference()
        {
            return radius * 2 * 3.14f;
        }
    }
}
