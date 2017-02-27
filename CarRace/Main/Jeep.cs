using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Main
{
    class Jeep : Car
    {
        private Thread thread;
        private object threadLock = new object();

        public Jeep(string name)
        {
            Name = name;
            MaxSpeed = 20;
            Health = R.Next(70, 120);
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

                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; i < Speed; i++)
                    {
                        Console.Write("-");
                        Thread.Sleep(100);
                        Distance++;

                        if (Distance >= 100)
                        {
                            Console.WriteLine("{0} on Finish !", nameof(Jeep) + " " + Name);
                            break;
                        }

                        if (i == Speed-1)
                            Console.WriteLine(">");
                    }

                    Speed = R.Next(1, MaxSpeed);

                    var k = R.Next(1, 7);

                    if (k == 1 || k == 3 || k == 6)
                        Health -= R.Next(5, 15);

                    if (Health <= 0)
                    {
                        Console.WriteLine("{0} is broken !", nameof(Jeep) + " " + Name);
                        break;
                    }

                    Statistics(this);

                }
                Thread.Sleep(100);

            } while (Distance <= 100);

            thread.Join();

            if (Distance >= 100)
                Console.WriteLine("{0} on Finish !", nameof(Jeep) + " " + Name);
        }

        public void Start(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("{0} begin race !", nameof(Jeep) + " " + Name);
            Thread.Sleep(700);
            thread = new Thread(Drive);
            thread.Start();
        }
    }
}
