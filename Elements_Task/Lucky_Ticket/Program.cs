using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Ticket
{
    /// <summary>
    /// Key in the number of tram ticket (6-digit number) 
    /// and pro-faith whether the happy ticket (if the ticket  is printed six-digit number, 
    /// and the sum of the first three digits equals the sum of the last three, then the ticket is considered lucky).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int first=0;
            int last=0;
            int[] arrayNumb = new int[6];
            int divNumb = 10;

            Console.WriteLine("Write number:");
            number = Int32.Parse(Console.ReadLine());

            for (int i = 5; i >= 0; i--)
            {
                if (i == 5)
                    arrayNumb[i] = (number % divNumb);
                else arrayNumb[i] = ((number % divNumb) - arrayNumb[i+1] ) / (divNumb/10) ;
                divNumb *= 10;
            }

            for (int i = 5; i >= 0; i--)
            {
                Console.Write("{0} ", arrayNumb[i]);
                if (i < 3)
                    first += arrayNumb[i];
                else last += arrayNumb[i];
            }

            Console.WriteLine();

            if (first == last)
                Console.WriteLine("It is lucky ticket");
            Console.ReadKey();

        }
    }
}
