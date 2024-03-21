using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT8._1
{
    internal class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public string publisher { get; set; }
        public string year { get; set; }
        public Book(int id, string name, string author, double price, string publisher, string year)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.price = price;
            this.publisher = publisher;
            this.year = year;
        }
        public override string ToString()
        {
            return "id: " + id + " name: " + name + " author: " + author
               + " price: " +price +" publisher: " + publisher + " year: " + year;
        }
    }
}
