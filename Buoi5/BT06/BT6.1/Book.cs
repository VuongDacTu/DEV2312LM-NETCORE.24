using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6._1
{
    internal class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Book() { }
        public Book(int id, string title,string author, string publisher, int year, double price) 
        {
            ID = id; 
            Title = title;
            Publisher = publisher;
            Year = year;
            Price = price;
            Author = author;
        }
        public override string ToString()
        {
            return String.Format("\n ID: {0} \nTitle: {1} \nAuthor:{5} \nPublisher: {2} \nYear: {3} \nPrice: {4}", ID, Title,Publisher,Year,Price,Author);
        }
    }
}
