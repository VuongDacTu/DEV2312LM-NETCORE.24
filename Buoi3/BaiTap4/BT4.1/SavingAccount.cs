using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4._1
{
    internal class SavingAccount : Acount
    {
        public double rate { get; set; }
        public SavingAccount() { }
        public SavingAccount(double initialize, double rate) : base(initialize)
        {
            this.rate = rate;
        }
        public void GetInterest()
        {
            double s = base.Balance * rate;
            Console.WriteLine( "Tien lai sau 1 thang la: " + s);
            base.Balance += s;
        }
    }
}
