using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4._2
{
    internal class NhanVienBanHang : NhanVien
    {
        public int Soluongbanduoc {  get; set; }
        public NhanVienBanHang(string ten,string diachi,int soluongbanduoc)
        {
            this.Ten = ten;
            this.DiaChi = diachi;
            Soluongbanduoc = soluongbanduoc;
        }

        public override void TinhLuong()
        {
            Console.WriteLine("Luong:\t" + Soluongbanduoc * 300);
        }
        public override void HienThi()
        {
            Console.WriteLine("Ten:\t" + Ten);
            Console.WriteLine("Dia chi:" + DiaChi);
        }
    }
}
