using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditVector
{
    /// <summary>
    /// Compress dimensional array by removing from it all 0 and fill the vacated right components -1.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[25];
            Random rand = new Random();
            int k = 0;

            Console.WriteLine(" Vector: ");

            for (int i = 0; i < 25; i++)
            {
                a[i] = rand.Next(0, 10);

                Console.Write(" {0}", a[i]);
            }

            for (int i = 0; i < 25; i++)
            {
                if (a[i] == 0) {  k += FindZero(a, i); i += 1; }
                else continue;
            }

            FillEmpty(a, k-1);

            Console.WriteLine();
            Console.WriteLine(" Change Vector: ");

            for (int i = 0; i < 25; i++)
            {

                Console.Write(" {0}", a[i]);
            }

            Console.WriteLine();

            Console.ReadKey();
        }

        static public int FindZero(int[] a, int i)
        {
            int k = 0;
            for (int j = i; j < 25; j++)
            {
                if (a[j] > 0)
                {
                    k = j - i;
                    for (int p = i; p < j; p++)
                    {
                        if (j < 25)
                        {
                            a[p] = a[j++];
                        }
                        else a[p] = -1;
                    }                
                    break;
                }
            }

            return k;
        }

        static public void FillEmpty(int[] a, int k)
        {
            for (int i = 24 - k; i < 25; i++)
            {
                a[i] = -1;
            }
        }
    }
}
