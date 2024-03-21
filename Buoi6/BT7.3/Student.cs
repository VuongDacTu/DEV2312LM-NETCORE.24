using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7._3
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int theorymark { get; set; }
        public int labmark { get; set; }
        public Student(int id, string name, int theorymark, int labmark)
        {
            this.id = id;
            this.name = name;
            this.theorymark = theorymark;
            this.labmark = labmark;
        }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.theorymark = 0;
            this.labmark = 0;
        }
        public override string ToString()
        {
            return string.Format("\nid:{0,-10}\nname:{1,-10}\ntheorymark:{2,-10}\nlabmark:{3,-10}", id, name, theorymark, labmark);

        }
    }
}
