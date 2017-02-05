using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Array
{
    /// <summary>
    /// Declare a one-dimensional (5 items) array named A and a two-dimensional array (3 rows, 4 columns) 
    /// fractional numbers with the name B. Fill one-dimensional array and the number entered 
    /// by the user keyboard, and two-dimensional array in random numbers using cycles. 
    /// Display the values of arrays: Array A one-line array B - in the form of a matrix.    a.Find the data arrays common maximal element,
    /// b.minimal element,
    /// c. the total amount of all elements,
    /// d. amount even elements of the array A,
    /// e.the amount of the odd lines of the array B.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            double[,] b = new double[3, 4];
            Random rand = new Random();
            double min = 100, max = 0;
            double s = 0, s1 = 0, s2 = 0;

            Console.WriteLine("Matrix: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    b[i, j] = Math.Round(rand.Next(1, 100) - rand.NextDouble(), 2);

                    s += b[i, j];

                    if (max < b[i, j])
                        max = b[i, j];

                    if (min > b[i, j])
                        min = b[i, j];

                    if (j % 2 != 0)
                        s1 += b[i, j];

                    Console.Write("{0} ", b[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Vector: ");

            for (int i = 0; i < 5; i++)
            {
                a[i] = rand.Next(1, 100);

                s += a[i];

                if (max < a[i])
                    max = a[i];

                if (min > a[i])
                    min = a[i];

                if (i % 2 == 0)
                    s2 += a[i];

                Console.Write("{0} ", a[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("max: {0}", max);
            Console.WriteLine("min {0}", min);
            Console.WriteLine("Sum : {0}", s);
            Console.WriteLine("Sum1 : {0}", s1);
            Console.WriteLine("Sum2 : {0}", s2);

            Console.ReadKey();

        }
    }
}
