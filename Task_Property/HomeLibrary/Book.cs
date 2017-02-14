using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    class Book
    {
        private string name;
        private string author;
        private string genre;
        private int year;

        public Book()
        {

        }
        public Book(string str)
        {
            Name = str;
        }
        public Book(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public Book this[string str]
        {
            get
            {
                Book bk = new Book(str);
                return bk;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1600)
                    year = value;
            }
        }

    }
}
