using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Book : IBook
    {
        private string isbn;
        private string title;
        private string author;
        private string pulisher;
        private int year;

        private ArrayList chapter = new ArrayList();




       
    string IBook.Title
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        string IBook.Author
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        string IBook.Pulisher
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        string IBook.ISBN
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        int IBook.Year
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string ISBN
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Pulisher
        {
            get
            {
                return pulisher;
            }

            set
            {
                pulisher = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

     

        public Book()
        {
        }

        public Book(string isbn, string title, string author, string pulisher, int year)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.Pulisher = pulisher;
            this.Year = year;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }


        public void Output()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Pulisher: " + Pulisher);
            Console.WriteLine("Isbn: " + ISBN);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0} : {1}", i + 1, chapter[i]);
            Console.WriteLine("--------------------------");

        }
        public void Input()
        {
            Console.Write("Enter Title: ");
            Title = Console.ReadLine();
            Console.Write("Enter Author: ");
            Author = Console.ReadLine();
            Console.Write("Enter Pulisher: ");
            Pulisher = Console.ReadLine();
            Console.Write("Enter ISBN: ");
            ISBN = Console.ReadLine();
            Console.Write("Enter Year: ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Input chapter (fishned with empty string): ");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);

            } while (str.Length > 0);

        }



    }

}
