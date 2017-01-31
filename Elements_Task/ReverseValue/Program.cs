using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseValue
{
    /// <summary>
    /// Given an integer N (> 0), find the number obtained 
    /// when the number N of read from right to left. For example, 
    /// if the number is 345, then the program must write the number 543 has been entered.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int size;
            int[] arrNumb = new int[10];
            int divNumb = 10;

            Console.WriteLine("Write size of number: ");
            size = Int32.Parse(Console.ReadLine()) - 1;

            Console.Write("Write number: ");
            number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (number % divNumb == number)
                {
                    size = i;
                    break;
                }

                divNumb *= 10;
            }

            divNumb = 10;

            for (int i = size; i >= 0; i--)
            {
                if (i == size)
                    arrNumb[i] = (number % divNumb);
                else arrNumb[i] = ((number % divNumb) - arrNumb[i + 1]) / (divNumb / 10);
                divNumb *= 10;
            }

            for (int i = size; i >= 0; i--)
            {
                Console.Write("{0} ", arrNumb[i]);
            }

            Console.ReadKey();
        }
    }
}
