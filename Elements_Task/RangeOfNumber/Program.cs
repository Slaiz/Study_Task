using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfNumber
{
    /// <summary>
    /// Two positive integers A and B (A < B )
    /// Output all integers from A to B inclusive; 
    /// each number must be displayed on a new line; 
    /// with each number should show the number of times equal to its value.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            do {

                Console.WriteLine("//////////////////////////////////////////\n");

                Console.Write("Enter a:");
                a = Int32.Parse(Console.ReadLine());

                if (a < 0)
                {
                    Console.WriteLine("Negative value");
                    continue;
                }

                Console.Write("Enter b:");
                b = Int32.Parse(Console.ReadLine());

                if (b < 0)
                {
                    Console.WriteLine("Negative value");
                    continue;
                }

                if (b < a)
                {
                    Console.WriteLine("A are gratest than B");
                    continue;
                }

                for (int i = a; i <= b; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("{0} ", i);
                    }

                    Console.WriteLine();
                }
              
            } while (Console.ReadKey().Key != ConsoleKey.DownArrow);

            Console.ReadKey();
        }
    }
}
