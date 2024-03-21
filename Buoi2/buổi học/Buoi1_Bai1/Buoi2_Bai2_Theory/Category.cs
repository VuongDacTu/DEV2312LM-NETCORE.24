using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Bai2_Theory
{
    /// <summary>
    /// 
    /// </summary>
    public class Category
    {
        // member: Field / properties (attribute)
        // Field: 
        private int id;
        private string name;
        // Propertis
        public int Id { get { return id; } set { id = value; } }
        public string Name { get; set; }
        /*
            private string _Name;
            public string Name {
                get {return _Name;}
                set {_Name = value;}
            }
         */
        // Method 
        public void Display()
        {
            Console.WriteLine("ID\t: {0}", Id);
            Console.WriteLine("Name\t: {0}", Name);
        }
        public Category( int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
