using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Main
{
    class SportCar : Car
    {
        private Thread thread;

        public SportCar(string name)
        {
            Name = name;
            MaxSpeed = 25;
            Health = R.Next(30, 75);
            Speed = R.Next(1, MaxSpeed);
            Program.OnStart += Start;
        }


        public override void Drive()
        {
            do
            {
                Statistics(this);

                lock (threadLock)
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    for (int i = 0; i < Speed; i++)
                    {
                        Console.Write("-");
                        Thread.Sleep(100);
                        Distance++;

                        if (Distance >= 100)
                        {
                            Console.WriteLine("{0} on Finish !", nameof(SportCar) + " " + Name);
                            break;
                        }


                        if (i == Speed - 1)
                            Console.WriteLine(">");
                    }

                    Speed = R.Next(1, MaxSpeed);

                    var k = R.Next(1, 5);

                    if (k == 1 || k == 3 || k == 4)
                        Health -= R.Next(1, 10);

                    if (Health <= 0)
                    {
                        Console.WriteLine("{0} is broken !", nameof(SportCar) + " " + Name);
                        break;
                    }

                    Statistics(this);
                }
                Thread.Sleep(100);
            } while (Distance <= 100);

            if (Distance >= 100)
                Console.WriteLine("{0} on Finish !", nameof(SportCar) + " " + Name);
        }

        public void Start(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("{0} begin race !", nameof(SportCar) + " " + Name);
            Thread.Sleep(300);
            thread = new Thread(Drive);
            thread.Start();
        }
    }
}
