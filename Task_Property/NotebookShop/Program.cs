using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook nt1 = new Notebook("HP", 120);
            Notebook nt2 = new Notebook("LG", 150);
            Notebook nt3 = new Notebook("Sumsung", 220);

            Notebook[] nt = new Notebook[] { nt1, nt2, nt3 };

            Shop sh  = new Shop(nt);

            Console.WriteLine("Vendor: {0}\nPrice: {1}\n", sh[1].Vendor, sh[1].Price);

            Notebook nt4 = sh["HP"];
            Console.WriteLine("Vendor: {0}\nPrice: {1}\n", nt4.Vendor, nt4.Price);

            Console.ReadKey();

        }
    }
}
