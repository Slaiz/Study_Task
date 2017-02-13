using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Class for work with bankomat
    /// </summary>
    class Client
    {
        private int balance;


        public Client()
        {

        }
        public Client(string name, int cardNumb, int password, int balance)
        {
            Name = name;
            CardNumb = cardNumb;
            Password = password;
            Balance = balance;
        }
        public Client(int cardNumb, int password, int balance)
        {
            CardNumb = cardNumb;
            Password = password;
            Balance = balance;
        }

        public string Name { get; set; }

        public int CardNumb { get; set; }

        public int Password { get; set; }

        public int Balance
        {
            get { return balance; }
            set { if (value > 0) balance = value; }
        }



    }
}
