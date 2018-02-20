using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginlivros
{
    class Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public int year { get; set; }

        public Book(string name, string author, int year)
        {
            this.name = name;
            this.author = author;
            this.year = year;
        }
    }
}
