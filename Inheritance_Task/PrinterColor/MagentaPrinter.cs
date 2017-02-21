using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterColor
{
    class MagentaPrinter:Printer
    {
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.ReadLine();
        }
    }
}
