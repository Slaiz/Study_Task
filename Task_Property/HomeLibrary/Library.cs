using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    class Library
    {
        private List<Book> bk;

        public Library()
        {
            bk = new List<Book>();
        }
        public void FindBook()
        {
            int ch;
            string str;
            int n;
            Book b = new Book();

            Console.WriteLine("Find by:\n1. Name\n2. Author\n3. Genre\n4. Year\n");
            ch = Int32.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine("Write name:");
                        str = Console.ReadLine();

                        for (int i = 0; i < bk.Capacity - 1; i++)
                        {
                            if (bk[i].Name == str)
                            {
                                b = bk[i];
                            }
                        }

                        Console.Clear();
                        PrintBook(b);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Write author:");
                        str = Console.ReadLine();

                        for (int i = 0; i < bk.Capacity - 1; i++)
                        {
                            if (bk[i].Author == str)
                            {
                                b = bk[i];
                            }
                        }

                        Console.Clear();
                        PrintBook(b);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Write name:");
                        str = Console.ReadLine();

                        for (int i = 0; i < bk.Capacity - 1; i++)
                        {
                            if (bk[i].Genre == str)
                            {
                                b = bk[i];
                            }
                        }

                        Console.Clear();
                        PrintBook(b);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Write name:");
                        n = Int32.Parse(Console.ReadLine());

                        for (int i = 0; i < bk.Capacity - 1; i++)
                        {
                            if (bk[i].Year == n)
                            {
                                b = bk[i];
                            }
                        }

                        Console.Clear();
                        PrintBook(b);
                    }
                    break;
                default:
                    break;
            }
        }

        public void SortBook()
        {
            int ch;

            Book temp;

            Console.WriteLine("Sort by:\n1. Name\n2. Author\n3. Genre\n4. Year\n");
            ch = Int32.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        for (int i = 0; i < bk.Capacity - 1; i++)
                        {
                            for (int j = 0; j < bk.Capacity - 2; j++)
                            {
                                if (bk[j].Year > bk[j+1].Year)
                                {
                                    temp = bk[j];
                                    bk[j] = bk[j + 1];
                                    bk[j + 1] = temp;
                                }
                            }
                        }

                        PrintAllBook();
                    }
                    break;
                case 2:
                    {
                        for (int i = 0; i < bk.Capacity - 1; i++)
                        {
                            for (int j = 0; j < bk.Capacity - 2; j++)
                            {
                                if (bk[j].Year > bk[j+1].Year)
                                {
                                    temp = bk[j];
                                    bk[j] = bk[j + 1];
                                    bk[j + 1] = temp;
                                }
                            }
                        }

                        PrintAllBook();
                    }
                    break;
                case 3:
                    {
                        for (int i = 0; i < bk.Capacity - 1; i++)
                        {
                            for (int j = 0; j < bk.Capacity - 2; j++)
                            {
                                if (bk[j].Year > bk[j+1].Year)
                                {
                                    temp = bk[j];
                                    bk[j] = bk[j + 1];
                                    bk[j + 1] = temp;
                                }
                            }
                        }

                        PrintAllBook();
                    }
                    break;
                case 4:
                    {
                        for (int i = 0; i < bk.Capacity - 1; i++)
                        {
                            for (int j = 0; j < bk.Capacity - 2; j++)
                            {
                                if (bk[j].Year > bk[j+1].Year)
                                {
                                    temp = bk[j];
                                    bk[j] = bk[j + 1];
                                    bk[j + 1] = temp;
                                }
                            }
                        }

                        PrintAllBook();
                    }
                    break;
                default:
                    break;
            }
        }

        public void AddBook()
        {
            string name;
            string author;
            string genre;
            int year;

            Console.WriteLine("Write name book:");
            name = Console.ReadLine();

            Console.WriteLine("Write author of book:");
            author = Console.ReadLine();

            Console.WriteLine("Write genre of book:");
            genre = Console.ReadLine();

            Console.WriteLine("Write year book:");
            year = Int32.Parse(Console.ReadLine());

            Book b = new Book(name, author, genre, year);

            Book b1 = b[name];

            Console.WriteLine("Book {0} is added !",b1.Name);

            bk.Add(b);
        }

        public void AddBook(Book b)
        {
            bk.Add(b);
        }

        public bool DeleteBook()
        {
            string str;
            Console.WriteLine("Write name book:");
            str = Console.ReadLine();

            for (int i = 0; i < bk.Capacity - 1; i++)
            {
                if (bk[i].Name == str)
                {
                    bk.Remove(bk[i]);
                    return true;
                }                
            }

            return false;
        }

        public void PrintAllBook()
        {
            for (int i = 0; i < bk.Capacity - 1; i++)
            {
                Console.WriteLine("Name: {0}\nAuthor: {1}\nGenre: {2}\nYear: {3}\n",bk[i].Name, bk[i].Author, bk[i].Genre, bk[i].Year);
            }
        }

        public void PrintBook(Book b)
        {
            Console.WriteLine("Name: {0}\nAuthor: {1}\nGenre: {2}\nYear: {3}\n", b.Name, b.Author, b.Genre, b.Year);
        }


    }
}
