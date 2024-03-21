using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    internal class Chapter
    {
        private string name;
        private string content;
        public Chapter()
        {
            name = "";
            content = "";
        }
        public Chapter (string name, string content)
        {
            this.name = name;
            this.content = content;
        }
        // định nghĩa các thuộc tính
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // ghi đè phương thức tostring
        public override string ToString()
        {
            return name + "\n" + content;
        }
    }
}
