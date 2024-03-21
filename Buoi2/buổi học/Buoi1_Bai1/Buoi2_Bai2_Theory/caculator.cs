using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Bai2_Theory
{  
    /// <summary>
    /// Lớp tính toán; static method; ref; out ...
    /// </summary>
    internal class caculator
    {
        public static int Add ( int a, int  b)
        {
            return a + b;
        }
        public static  int Sub (int a, int b)
        {
            return (a - b);
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public void Calc(int a, int b, out int cong, out int tru)
        {
            cong = a +b;
            tru = a-b;
        }
        public void Swapref (ref int x, ref int y)
        {
            int temp = x;
            x = y; 
            y = temp;
        }
        public void Swap( int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
