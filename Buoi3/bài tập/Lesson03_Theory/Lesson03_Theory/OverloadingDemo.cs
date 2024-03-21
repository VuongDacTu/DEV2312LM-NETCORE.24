using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    /// <summary>
    /// Cài đặt tính chất đa hình trong OOP
    /// - Có cùng tên
    /// - Danh sách tham số khác nhau
    /// - Nếu danh sách ham số giống thì phải khác nhau về kiểu dữ liệu
    /// </summary>
    internal class OverloadingDemo
    {
        public int Sum(int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += i;
            }
            return tong;
        }
        public int Sum(int n, int n2)
        {
            int tong = 0;
            for (int i = n; i <= n2; i++)
            {
                tong += i;
            }
            return tong;
        }
        public double Sum(double n, double n2) 
        {

            double tong = n + n2;
            return tong;
        }
    }
    }

