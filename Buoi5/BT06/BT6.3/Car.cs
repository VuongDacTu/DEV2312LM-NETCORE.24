using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6._3
{
    internal class Car
    {
        public string name { get; set; }
        public string color { get; set; }
        public Car() { }
        public Car(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public override string ToString()
        {
            return string.Format("\nName:v{0}\nColor: {1}",name,color);
        }
    }
}
