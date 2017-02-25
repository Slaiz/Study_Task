using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            WordCounter wc = new WordCounter();

            //string str = Console.ReadLine();

            string str =
                "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, " +
                "Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, " +
                "Которая в темном чулане хранится В доме, Который построил Джек.";

            wc.Count(str);

            Console.ReadKey();
        }
    }
}
