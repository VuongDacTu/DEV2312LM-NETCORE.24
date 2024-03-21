using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7._2
{
    internal class ConBo
    {
        public int Loai { get; set; }
        public ConBo(int loai)
        {
            Loai = loai;
        }
        public override string ToString()
        {
            return "Loai: " + Loai;
        }
    }
}
