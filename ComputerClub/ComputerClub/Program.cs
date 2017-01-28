using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerClub
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbComp,a=1, b=10;
            int rModel;
            Random rand = new Random();        

            Console.WriteLine("Number computer: ");
            numbComp = Int32.Parse(Console.ReadLine());

            Computer[] userComp = new Computer[numbComp+1];

            for (int i = 0; i < numbComp; i++)
            {
                rModel = rand.Next(a,b);
                a += 10; b += 10;

                userComp[i] = new Computer(rModel.ToString(), false);
            }

            Computer adminComp = new Computer("HP 1001", true);

            userComp[numbComp] = adminComp;

            Console.WriteLine("Choose command:\n 1. Reboot all\n ");

            for (int i = 0; i < numbComp+1; i++)
            {
                userComp[i].Reboot();
            }

            Console.ReadKey();
        }
    }
}
