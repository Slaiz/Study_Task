using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    /// <summary>
    /// Create a class book (title, author, genre, year of publication). For each field, describe the properties.
    /// Create a class library Home.
    /// Provide the ability to work with any number of books, search books on any ground(by author, publication year or genre), 
    /// adding the book to the library, remove the books from it.Write a program designed demonstriruschuyu all elements of the class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Kova","Vesur","Fantastic",2005);
            Book b2 = new Book("Tobius","Ura","Poem",2002);
            Book b3 = new Book("Dragon", "Kire", "Novela", 2007);

            Library lib = new Library();

            lib.AddBook(b1);
            lib.AddBook(b2);
            lib.AddBook(b3);

            int ch;

            do
            {
                Console.WriteLine("Choose operation:\n1. Print all book\n2. Add book\n3. Delete book\n4. Find book\n5. Sort book");
                ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.Clear();
                            lib.PrintAllBook();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            lib.AddBook();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            if (lib.DeleteBook())
                                Console.WriteLine("Book is delete !");
                            else Console.WriteLine("Book is not exist !");
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            lib.FindBook();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            lib.SortBook();
                            break;
                        }
                    default:
                        break;
                }


            } while (Console.ReadKey().Key != ConsoleKey.DownArrow);
        }
    }
}
