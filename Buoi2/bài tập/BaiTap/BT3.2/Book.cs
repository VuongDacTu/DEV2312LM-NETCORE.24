using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._2
{
    internal class Book
    {
        public string author { get; set; }
        public int pages { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int currentPage = 1;
        
        public Book(string author, int pages, string isbn, string title)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
        }
        public Book() 
        {
        }
        public void Display()
        {
            Console.WriteLine("author:\t\t" + author);
            Console.WriteLine("pages:\t\t" +  pages);
            Console.WriteLine("isbn:\t\t" +  isbn);
            Console.WriteLine("title:\t\t" +  title);
            Console.WriteLine("currentPage:\t" +  currentPage);
        }
        public int flipPageForward()
        {
            currentPage++;
            return currentPage;
        }
        public int flipPageBackward() 
        {
            currentPage--;
            return currentPage;
        }
    }
}
