using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class BookComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int rs = x.Title.CompareTo(y.Title);
            if (rs == 0)
                rs = x.Author.CompareTo(y.Author);
            if (rs == 0)
                rs = x.Pulisher.CompareTo(y.Pulisher);
            if (rs == 0)
                rs = x.ISBN.CompareTo(y.ISBN);
            if (rs == 0)
                rs = x.Year.CompareTo(y.Year);
            return rs;


        }
    }
}
