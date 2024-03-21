using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    internal class Book
    {
        // khai báo trường
        private string name;
        private Chapter[] chapters;
        public Book(string name, int n)
        {
            this.name = name;
            this.chapters = new Chapter[n];
        }
        public Book()
        {

        }
        
        // định nghĩa các thuộc tính
        public string Name
        {
            get { return name; }
            set 
            {
                if(value == null)
                    throw new ArgumentNullException();
                name = value;
            }
        }
        // indexer thứ nhất có 1 tham số kiểu int
        public Chapter this[int index]
        {
            get
            {
                if (index < 0 || index > chapters.Length - 1) return null;
                return chapters[index];
            }
            set
            {
                if(index < 0 || index > chapters.Length - 1)
                    throw new ArgumentOutOfRangeException();
                chapters[index] = value;
            }
        }
        // indexer thứ hai có một tham số kiểu string overload indexer
        public Chapter this[string name]
        {
            get
            {
                foreach(Chapter chapter in chapters)
                {
                    if(chapter.Name == name) return chapter;
                }
                return null;
            }
        }
    }
}
