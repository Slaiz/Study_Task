using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int ch;
            WorkString WStr = new WorkString();

            do
            {
                Console.WriteLine("Write string:");
                str = Console.ReadLine();

                Console.WriteLine("Choose operation:\n1. Info\n2. Without number\n3. Symbol Up\n4. Replace word\n");
                ch = Int32.Parse(Console.ReadLine());


                switch (ch)
                {
                    case 1:
                        {
                            WStr.Info(str);
                            break;
                        }
                    case 2:
                        {
                            WStr.WithoutNumbers(str);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Write symbol:");
                            char c = Char.Parse(Console.ReadLine());
                            WStr.SymbolUp(str, c);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Write old word: ");
                            string s1 = Console.ReadLine();

                            Console.WriteLine("Write new word: ");
                            string s2 = Console.ReadLine();

                            WStr.ReplaceWord(str, s1, s2);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            } while (Console.ReadKey().Key != ConsoleKey.DownArrow);

        }
    }
}
