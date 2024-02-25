using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }  
        public string Year { get; set; }

        public override string ToString()
        {
            return $"Title : {Title} \nAuthor : {Author} \nYear : {Year}\n";
        }
    }
}