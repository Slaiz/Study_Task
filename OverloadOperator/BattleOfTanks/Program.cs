using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTanks
{
    /// <summary>
    /// Develop a program that simulates tank battle. 
    /// 5 involved tanks "T-34" and 5 tanks, "the Pantera" in a tank battle. Each tank ( "T-34" and "the Pantera") 
    /// describes the parameters: "Ammunition", "Armor Level", "The level of maneuverability." 
    /// The value of these parameters are given by random numbers from 0 to 100. 
    /// Each tank takes part in the Battle of the pair, ie, the first tank "T-34" tank with the first fight, "the Pantera", etc.
    /// Victory is awarded to the tank, which is higher than the opponent by two or more of the three parameters. 
    /// Total victory is awarded to the battle of the commando, who won greater number of battles. 
    /// The main requirement: the battle (check for victory in battle) implemented by overload "*" operator (the product).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, m=0;
            Random rand = new Random();

            Tank[] t1 = new Tank[5] { new Tank("T1", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)),
                new Tank("T2", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)), new Tank("T3", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)),
                new Tank("T4", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)), new Tank("T5", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)), };

            Tank[] k1 = new Tank[5] { new Tank("K1", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)),
                new Tank("K2", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)), new Tank("K3", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)),
                new Tank("K4", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)), new Tank("K5", rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100)), };

            Tank[] s1 = new Tank[5];

            for (int i = 0; i < 5; i++)
            {
                s1[i] = k1[i] * t1[i];
                if (s1[i].Name == t1[i].Name)
                    n++;
                else m++;
            }

            if (n > m)
                Console.WriteLine("Win division T ! \nVictory - {0} \nLose - {1}\n", n,m);
            else Console.WriteLine("Win division K ! \nVictory - {0} \nLose - {1}\n", m, n);

            for (int i = 0; i < 5; i++)
            {
                t1[i].Decription();
                k1[i].Decription();
            }

            Console.ReadKey();
        }
    }
}
