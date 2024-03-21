using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4._2
{
    internal class CongNhan : NhanVien
    {
        public int Soluongsanpham { get; set; }
        public CongNhan(string ten, string diachi, int soluongsanpham)
        {
            this.Ten = ten;
            this.DiaChi = diachi;
            this.Soluongsanpham = soluongsanpham;
        }
        public override void TinhLuong()
        {
            Console.WriteLine("Luong:\t" +  Soluongsanpham*200);

        }
        public override void HienThi()
        {
            Console.WriteLine("Ten:\t" + Ten);
            Console.WriteLine("Dia chi:" + DiaChi);
        }
    }
}
