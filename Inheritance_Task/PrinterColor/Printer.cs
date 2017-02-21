using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterColor
{
    class Printer
    {
        public virtual void Print()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
