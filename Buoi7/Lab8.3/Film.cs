using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    internal class Film
    {
        public string FilmID { get; set; }
        public string FilmName { get; set;}
        public int Price { get; set; }
        public Film (string filmid, string filmidname, int price)
        {
            this.FilmID = filmid;
            this.FilmName = filmidname;
            this.Price = price;
        }
        public override string ToString()
        {
            return FilmID + ":" + FilmName + ":" + Price;
        }
    }
}
