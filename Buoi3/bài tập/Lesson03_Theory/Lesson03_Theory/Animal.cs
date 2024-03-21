using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dong vat an mot vai thu");
        }
        public void DoSomeThing()
        {
            Console.WriteLine("Dong vat lam moi vai thu");
        }
    }
    class Cat : Animal
    {
        public void Action()
        {
            Eat();
            DoSomeThing();
        }
    }
}
