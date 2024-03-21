using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4._1
{
    internal class CheckAccount : Acount
    {
        public double FeeTransfer { get; set; }
        public CheckAccount(double Balannce,double feeTransfer) : base(Balannce)
        {
            this.FeeTransfer = feeTransfer;
        }
        public override void Deposit(double money)
        {
            base.Deposit(money);
            Console.WriteLine("So tien bi tru sau khi giao dich la: {0}", FeeTransfer);
            base.Balance -= FeeTransfer;

        }
        public override void WithDraw(double money)
        {
            base.WithDraw(money);
            Console.WriteLine("So tien bi tru sau khi giao dich la: {0}", FeeTransfer);
            base.Balance -= FeeTransfer;

        }
    }
}
