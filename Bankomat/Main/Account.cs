using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Class for create date of client 
    /// </summary>
    class Account
    {
        private string[] password;
        Client[] cls;
        private int n = 0;
        private int k = 0;

        public Account()
        {
            password = new string[100];
            cls = new Client[100];
        }

        public Client CreateAcc()
        {
            Client cl = new Client();
            Console.WriteLine("Please write your name: ");
            cl.Name = Console.ReadLine();

            CreateCardNumber(cl);
            CreatePassword(cl);

            Console.WriteLine("Your card number: {0}\nYour Password: {1}\n", cl.CardNumb, cl.Password);

            return cl;
        }

        private void CreatePassword(Client cl)
        {
            Random rand = new Random();

            cl.Password = rand.Next(1111,9999);
            password[n] += cl.Password;
            n++;
        }

        public bool CheckPassword(Client cl, int pass)
        {
            if (cl.Password == pass)
                return true;
            else return false;
        }

        private void CreateCardNumber(Client cl)
        {
            bool flag = true;

            do {
                Random rand = new Random();

                cl.CardNumb = rand.Next(111111, 999999);
                for (int i = 0; i < k; i++)
                {
                    if (cls[i].CardNumb == cl.CardNumb)
                        flag = true;
                    else flag = false;
                }
            } while (flag);

            cls[k] = cl;
            k++;
        }

        public Client CheckCardNumber(int cardNumb)
        {
            for (int i = 0; i < k; i++)
            {
                if (cls[i].CardNumb == cardNumb)
                    return cls[i];              
            }

            return null;
        }

        public void AddClient(Client cl)
        {
            cls[k] = cl;
            k++;
        }


    }
}
