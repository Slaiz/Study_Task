﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterColor
{
    class GreenPrinter:Printer
    {
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadLine();
        }
    }
}
