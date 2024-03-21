using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    internal class Car
    {
        // khai báo các trường với phạm vi public
        public string make;
        public string model;
        public string color;
        public int year;
        // định nghĩa phương thức start
        public Car(string make, string model, string color, int year) 
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;        }
        public void Start()
        {
            System.Console.WriteLine(model + " Khoi dong");
        }
        // định nghĩa phương thức stop
        public void Stop() 
        { 
            System.Console.WriteLine(model + " dung");
        }
        public void Show()
        {
            System.Console.WriteLine("Thong tin chi tiet: ");
            System.Console.WriteLine("Make: " + make);
            System.Console.WriteLine("Model: " + model);
            System.Console.WriteLine("Color: " + color);
            System.Console.WriteLine("Year ralease: " + year);
        }
    }
}
