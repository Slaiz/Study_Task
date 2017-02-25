using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Main
{
    abstract class Car
    {
        public Random R = new Random();
        public string Name { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }
        public int Health { get; set; }
        public int Distance { get; set; }

        public abstract void Drive();

        public void SetColor(Car car)
        {
            switch (car.MaxSpeed)
            {
                case 25:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    }
                case 20:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case 18:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    }
                case 12:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;

                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    }
            }
        }

        public void Statistics(Car car)
        {
            SetColor(car);
            Console.WriteLine("\n>" + nameof(Car) + " " + Name);
            Console.WriteLine("{0} km to finish", 100 - Distance);
            Console.WriteLine("Health: {0}\nSpeed: {1}", Health, Speed);
            Thread.Sleep(300);
        }
    }
}
