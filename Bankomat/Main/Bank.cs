using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Class for work  with bank account
    /// </summary>
    class Bank
    {
        public void PrintBalance(Client cl)
        {
            Console.WriteLine("Your balance: {0}\n", cl.Balance);
        }

        public void AddBalance(Client cl,int sum)
        {
            cl.Balance += sum;
            Console.WriteLine("Your balance incresed by {0} UAH\n",sum);
        }

        public void SubBalance(Client cl, int sum)
        {
            if (cl.Balance >= sum)
            {
                cl.Balance -= sum;
                Console.WriteLine("Your balance reduced by {0} UAH\n", sum);
            }
            else Console.WriteLine("You can not take money, your balance are small than sum\n ");
        }

        public void ShowDate(Client cl)
        {
            Console.WriteLine("Card number: {0}\nPassword: {1}\n", cl.CardNumb, cl.Password);
        }


    }
}
