using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where_dot
{
    /// <summary>
    /// Write a program that reads characters from the keyboard, 
    /// until a point is entered. The program should count 
    /// the number entered by the user spaces.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            char inputStr;
            string outputStr = "";
            int n = 0;

            do
            {
                Console.Write("Write symbol: ");
                inputStr = Convert.ToChar(Console.ReadLine());
                if (inputStr == '.')
                    break;
                else if (inputStr == ' ')
                    n++;

                outputStr += inputStr;
                inputStr = '\0';

            }
            while (Console.ReadKey().Key != ConsoleKey.DownArrow);

            Console.WriteLine();
            Console.WriteLine("String: {0}", outputStr);
            Console.WriteLine("Space: {0}", n);

            Console.ReadKey();
        }
    }
}
