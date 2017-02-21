using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterColor
{
    class RedPrinter:Printer
    {
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
        }
    }
}
