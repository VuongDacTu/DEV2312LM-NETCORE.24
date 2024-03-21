using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    internal class Button : Window
    {
        public Button(int top, int left): base(top, left) { }
        // ghi đè phương thức
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }
}
