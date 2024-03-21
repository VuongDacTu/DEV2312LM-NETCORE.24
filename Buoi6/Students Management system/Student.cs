using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Management_system
{
    public class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; private set; }

        public int[] MarkList = new int[3];
        public int this[int i]
        {
            get { return MarkList[i]; }
            set { MarkList[i] = value; }
        }



        public void Print()
        {
            Console.WriteLine("Student ID: \t"+StudID );
            Console.WriteLine("Student Name: \t" +StudName);
            Console.WriteLine("Student Gender: \t" + StudGender);
            Console.WriteLine("Student Age: \t" + StudAge);
            Console.WriteLine("Student Class: \t" + StudClass);
        }

        public float CalAvg()
        {
            return (MarkList[0] + MarkList[1] + MarkList[2]) / 3;
        }
    }

}
