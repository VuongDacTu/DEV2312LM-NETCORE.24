using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    internal class Staff:IPerson
    {
        public void Insert(object obj)
        {
            Console.WriteLine("Da luu doi tuong: " + obj);

        }
        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhat doi tuong: "  + obj);
        }
        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }
        public void Display(object obj) 
        {
            Console.WriteLine("Thong tin doi tuong: " + obj);
        }
    }
}
