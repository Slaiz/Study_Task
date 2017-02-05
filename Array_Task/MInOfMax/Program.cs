using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInOfMax
{
    class Program
    {
        /// <summary>
        /// Given a two-dimensional array of size 7x8, filled with random numbers in the range of -100 to 100. 
        /// Find Element, which is a minimum value among the maximum of elements of each line.
        /// </summary>

        static void Main(string[] args)
        {
            double[,] a = new double[7, 8];
            double[] b = new double[7];
            Random rand = new Random();
            double min, max = -100;

            Console.WriteLine("Matrix: ");

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    a[i, j] = Math.Round(rand.Next(-100, 100) - rand.NextDouble(), 1);

                    if (j == 7)
                    {
                        max = -100;

                        for (int p = 0; p < 8; p++)
                        {
                            if (max < a[i, p])
                            { max = a[i, p];  }
                        }

                        b[i] = max;
                    }

                    Console.Write("{0} ", a[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Vector of max element each row : ");
            min = b[0];

            for (int i = 0; i < 7; i++)
            {
                if (min > b[i])
                    min = b[i]; 
                Console.Write("{0} ", b[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Min of max: {0}", min);

            Console.ReadKey();
        }
    }
}
