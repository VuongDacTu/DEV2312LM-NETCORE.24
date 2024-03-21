using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7._2
{
    internal class SinhVien
    {
        public int MyProperty { get; set; }
        public string MyProperty1 { get; set; }
        public SinhVien() { }
        public SinhVien(int myProperty, string myProperty1)
        {
            MyProperty = myProperty;
            MyProperty1 = myProperty1;
        }

        public override string ToString()
        {
            return "MyProperty: "+ MyProperty+ "\tMyProperty1: " + MyProperty1;
        }


    }
}
