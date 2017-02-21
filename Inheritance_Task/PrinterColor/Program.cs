using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterColor
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Printer p;

            do
            {
                Console.Clear();
                Console.WriteLine("\nWrite color of text:\n1. White\n2. Green\n3. Red\n4. Yellow\n5. Magenta\n");
                ch = Int32.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            p = new Printer();
                            p.Print();
                            break;
                        }
                    case 2:
                        {
                            p = new GreenPrinter();
                            p.Print();
                            break;
                        }
                    case 3:
                        {
                            p = new RedPrinter();
                            p.Print();
                            break;
                        }
                    case 4:
                        {
                            p = new YellowPrinter();
                            p.Print();
                            break;
                        }
                    case 5:
                        {
                            p = new MagentaPrinter();
                            p.Print();
                            break;
                        }
                    default:
                        break;

                }
            } while (Console.ReadKey().Key != ConsoleKey.UpArrow);

        }
    }
}
