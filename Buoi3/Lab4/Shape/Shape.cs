using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape
    {
        protected float radius, length, width;
        public abstract float Area();// diện tích
        public abstract float Circumference(); // tính chu vi
    }
}
