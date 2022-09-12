using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    internal class ListBook
    {
        private List<Book> list = new List<Book>();


        public ListBook()
        {
        }

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);

        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Output();
        }
        public void InputList()
        {
            int n;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
        public void SortMultiple()
        {
            list.Sort(new BookComparer());
        }

    }

}

