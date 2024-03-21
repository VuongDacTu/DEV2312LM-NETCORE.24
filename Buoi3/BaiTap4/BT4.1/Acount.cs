using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4._1
{
    internal class Acount
    {
        
        public double Balance { get; set; }
        public Acount() { }
        public Acount(double initialize) 
        {
             this.Balance = initialize;
        }
        public virtual void Deposit(double money)
        {
            Balance += money;
            Console.WriteLine("Ban da gui: {0} nghin dong", money );
        }
        public virtual void WithDraw(double money)
        {
            Balance -= money;
            Console.WriteLine("Ban da rut: {0} nghin dong", money);
        }
        public void GetBalance()
        {
            Console.WriteLine("So tien hien tai la: {0} nghin dong ", Balance);
        }
    }
}
