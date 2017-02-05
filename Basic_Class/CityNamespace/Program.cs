using GreatBritan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukraine;
using USA;

namespace CityNamespace
{
    /// <summary>
    /// To develop the application, which would have compared the population of the three capitals 
    /// of various countries (find the capital with the highest). 
    /// Moreover, the country would be designated namespace, and the city - in a class dan space.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Kiev k = new Kiev();
            London l = new London();
            Washington w = new Washington();

            Console.WriteLine("Write count of people in Kiev: ");
            k.PeopleCount = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Write count of people in London: ");
            l.PeopleCount = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Write count of people in Washington: ");
            w.PeopleCount = Int32.Parse(Console.ReadLine());

            if (k.PeopleCount >= l.PeopleCount)
                if (k.PeopleCount > w.PeopleCount)
                    Console.WriteLine(" In Kiev are more people");
            if (k.PeopleCount <= l.PeopleCount)
                if (l.PeopleCount > w.PeopleCount)
                    Console.WriteLine(" In London are more people");
            if (w.PeopleCount >= l.PeopleCount)
                if (k.PeopleCount < w.PeopleCount)
                    Console.WriteLine(" In washington are more people");

            //Dictionary<string, long> d = new Dictionary<string, long>;
            //d.Add("Kiev",k.PeopleCount);
            //d.Add("London", l.PeopleCount);
            //d.Add("Washington", w.PeopleCount);

            Console.ReadKey();
        }
    }
}
