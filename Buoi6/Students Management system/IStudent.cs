using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Management_system
{
    interface IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; }
        void Print();
    }
}
