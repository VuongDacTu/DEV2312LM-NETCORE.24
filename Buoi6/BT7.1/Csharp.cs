using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat
{
    namespace AnCo
    {
        public class  Bo
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }
            public Bo() { }
            public Bo(int iD, string name, double weight)
            {
                ID = iD;
                Name = name;
                Weight = weight;
            }
            public override string ToString()
            {
                return string.Format("{0,-5}{1,-15}{2,10}",ID,Name,Weight);
            }

        }
        public class Trau
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }
            public Trau() { }
            public Trau(int iD, string name, double weight)
            {
                ID = iD;
                Name = name;
                Weight = weight;
            }
            public override string ToString()
            {
                return string.Format("{0,-5}{1,-15}{2,10}", ID, Name, Weight);
            }
        }
        public class De
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }
            public De() { }
            public De(int iD, string name, double weight)
            {
                ID = iD;
                Name = name;
                Weight = weight;
            }
            public override string ToString()
            {
                return string.Format("{0,-5}{1,-15}{2,10}", ID, Name, Weight);
            }
        }
    }
    namespace AnThit
    {
        public class CaSau
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }
            public CaSau() { }
            public CaSau(int iD, string name, double weight)
            {
                ID = iD;
                Name = name;
                Weight = weight;
            }
            public override string ToString()
            {
                return string.Format("{0,-5}{1,-15}{2,10}", ID, Name, Weight);
            }
        }
        public class Ho
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }
            public Ho() { }
            public Ho(int iD, string name, double weight)
            {
                ID = iD;
                Name = name;
                Weight = weight;
            }
            public override string ToString()
            {
                return string.Format("{0,-5}{1,-15}{2,10}", ID, Name, Weight);
            }
        }
        public class SuTu
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }
            public SuTu() { }
            public SuTu(int iD, string name, double weight)
            {
                ID = iD;
                Name = name;
                Weight = weight;
            }
            public override string ToString()
            {
                return string.Format("{0,-5}{1,-15}{2,10}", ID, Name, Weight);
            }
        }
    }
    public class Program
    { 

        public void Display()
        {
            AnCo.Bo bo = new AnCo.Bo(1, "Co Be", 79.9);
            AnCo.De de = new AnCo.De(1, "Tay Tang", 60.5);
            AnCo.Trau trau = new AnCo.Trau(1, "Co", 80.7);
            AnThit.CaSau casau = new AnThit.CaSau(1, "Da Tron", 60.3);
            AnThit.Ho ho = new AnThit.Ho(1, "Van", 20.4);
            AnThit.SuTu sutu = new AnThit.SuTu(1, "Khon Duoi", 45.6);
            Console.WriteLine(bo.ToString());
            Console.WriteLine(de.ToString());

            Console.WriteLine(trau.ToString());

            Console.WriteLine(casau.ToString());

            Console.WriteLine(ho.ToString());

            Console.WriteLine(sutu.ToString());


        }
    }
}
