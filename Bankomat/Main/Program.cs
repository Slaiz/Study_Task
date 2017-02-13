using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Write an application that simulates the operation of the ATM.
    /// Implement Bank classes, Client, Account. Initially, the client needs to open a bank account, get an account number to receive your password, put the amount into the account.
    /// 1. The application proposes to introduce a number of alleged credit card, if you have an account with that number, the application prompts you to enter a password card, given 3 attempts to enter the correct password. If attempts are exhausted, the application gives a message and returns to input numbers.
    /// 2. If successful, entering the password is displayed greeting and menu. The user can select one of several actions:
    /// - Withdrawal of the balance of the screen
    /// - refill
    /// - withdraw money from the account
    /// - Exit to the previous menu.
    /// 3. If the user selects the output balance of the screen, the application displays the status of the alleged account, and then offers a return to the menu or to make output to input numbers.
    /// 4. If the user selects the completion of counting, the program asks for the amount of replenishment, and performs the operation, accompanying its output corresponding comment.This is followed by an offer to return to the menu or perform output to input numbers.
    /// 5. If the user chooses to withdraw money from the account, the program asks for the amount. If the amount exceeds the sum of the user account, the program displays a message and puts the user in the menu. Otherwise, it displays a message stating that the amount withdrawn from the account and reduces the amount of the account by the specified amount.
    /// Create at least 3 accounts in the bank.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Client cl1 = new Client("Slaiz", 11, 5089, 10000);
            Client cl2 = new Client("Bedro", 20, 1111, 250);
            Client cl;

            Account acc = new Account();
            Bank bank = new Bank();

            int ch;
            int sum;
            bool flag = true;

            acc.AddClient(cl1);
            acc.AddClient(cl2);

            do
            {

                cl = LogIn(acc);
                if (cl == null)
                    continue;
                else
                {
                    flag = true;

                    do
                    {
                        Console.WriteLine("Choose operation:\n1. Print Balance\n2. Add money on balance\n3. Take money from balance\n4. Show date\n5. Exit ");
                        ch = Int32.Parse(Console.ReadLine());

                        switch (ch)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    bank.PrintBalance(cl);
                                    break;
                                }
                            case 2:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Write sum:");
                                    sum = Int32.Parse(Console.ReadLine());
                                    bank.AddBalance(cl, sum);
                                    break;
                                }
                            case 3:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Write sum:");
                                    sum = Int32.Parse(Console.ReadLine());
                                    bank.SubBalance(cl, sum);
                                    break;
                                }
                            case 4:
                                {
                                    Console.Clear();
                                    bank.ShowDate(cl);
                                    break;
                                }
                            case 5:
                                {
                                    Console.Clear();
                                    flag = false;
                                    break;
                                }
                            default:
                                break;
                        }


                    } while (flag);
                }

            } while (Console.ReadKey().Key != ConsoleKey.DownArrow);
        }

        private static Client LogIn(Account acc)
        {
            int ch;
            int cardNumb;
            int pass;

            Console.Clear();

            Console.WriteLine("Welcom in WBank !\nAre you have card ?\n1. Yes\n2. No");
            ch = Int32.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Please write card number:");
                        cardNumb = Int32.Parse(Console.ReadLine());
                        Client cl = acc.CheckCardNumber(cardNumb);

                        if (cl == null)
                        {
                            Console.WriteLine(" Card number is wrong !");
                            break;
                        }
                        else
                            for (int i = 3; i > 0; i--)
                            {
                                Console.Clear();
                                Console.WriteLine("Please, {0} write password:", cl.Name);
                                pass = Int32.Parse(Console.ReadLine());
                                if (acc.CheckPassword(cl, pass))
                                    return cl;
                                else if (i == 1)
                                {
                                    Console.WriteLine("Sorry but you dont have any attempts. Goodbye !");
                                    return null;
                                }
                                else Console.WriteLine("Password is wrong !\nYou have {0} attempts", i);

                                Console.ReadKey();
                            }

                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Client cl = acc.CreateAcc();
                        return cl;
                        break;
                    }
                default:
                    break;
            }

            return null;
        }
    }
}
