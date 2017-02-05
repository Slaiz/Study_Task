using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeRowCollumn
{
    /// <summary>
    /// The two-dimensional array of the order of M by N swap specified columns.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            Random rand = new Random();
            int n, p, k;

            Console.WriteLine("Matrix: ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = rand.Next(1, 100);

                    Console.Write(" {0}", a[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            do
            {

                Console.WriteLine("Choose what change:\n1. Collumn\n2. Row ");
                n = Int32.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("Choose 1 collumn: ");
                            k = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Choose 2 collumn: ");
                            p = Int32.Parse(Console.ReadLine());
                            if (CheckNumber(k, p))
                                ChangeCollumn(a, k - 1, p - 1);
                            else break;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Choose 1 row: ");
                            k = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Choose 2 row: ");
                            p = Int32.Parse(Console.ReadLine());
                            if (CheckNumber(k, p))
                                ChangeRow(a, k - 1, p - 1);
                            else break;
                            break;
                        }
                    default:
                        break;
                }

                Console.WriteLine(" Change Matrix: ");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(" {0}", a[i, j]);
                    }

                    Console.WriteLine();
                }

            } while (Console.ReadKey().Key != ConsoleKey.DownArrow);

            Console.ReadKey();
        }

        static public void ChangeRow(int[,] a, int k, int p)
        {
            int[] b = new int[5];
            int[] c = new int[5];


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == k)
                        b[j] = a[i, j];
                    if (i == p)
                        c[j] = a[i, j];

                }

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (i == k)
                        a[i, j] = c[j];
                    if (i == p)
                        a[i, j] = b[j];
                }

            }
        }

        static public void ChangeCollumn(int[,] a, int k, int p)
        {
            int[] b = new int[5];
            int[] c = new int[5];


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == k)
                        b[i] = a[i, j];
                    if (j == p)
                        c[i] = a[i, j];

                }

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (j == k)
                        a[i, j] = c[i];
                    if (j == p)
                        a[i, j] = b[i];
                }

            }
        }

        static public bool CheckNumber(int k, int p)
        {
            if (k > 5 && p > 5 || k < 0 && p < 0)
                return false;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Invalid number ");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
        }
    }
}
