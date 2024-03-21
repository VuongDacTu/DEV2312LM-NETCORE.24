using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4._2
{
    public abstract class NhanVien
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public abstract void TinhLuong();
        public abstract void HienThi();
    }
}
