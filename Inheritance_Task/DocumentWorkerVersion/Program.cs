using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkerVersion
{

    class Program
    {
        static void Main(string[] args)
        {
            string pass;
            DocumentWorker dw;

            do
            {
                Console.Clear();
                Console.WriteLine("Write password ");
                pass = Console.ReadLine();

                switch (pass)
                {
                    case "1111":
                        {
                            dw = new ExpertDocumentWorker();
                            dw.OpenDocument();
                            dw.EditDocument();
                            dw.SaveDocument();
                            break;
                        }
                    case "2222":
                        {
                            dw = new ProDocumentWorker();
                            dw.OpenDocument();
                            dw.EditDocument();
                            dw.SaveDocument();
                            break;
                        }
                    default:
                        dw = new DocumentWorker();
                        dw.OpenDocument();
                        dw.EditDocument();
                        dw.SaveDocument();
                        break;

                }
            } while (Console.ReadKey().Key != ConsoleKey.UpArrow);
        }
    }
}
