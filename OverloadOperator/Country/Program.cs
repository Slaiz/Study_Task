using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country
{
    /// <summary>
    /// Create Country class (country)
    /// With the help of operator overloading to implement:
    /// Merging the two countries (+). The new name of the two countries consists of two former names hyphenated.
    /// Comparison of the two countries in the area(>, <).
    /// Comparison of the two countries in terms of population(==,! =).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Country c1 = new Country("Ukr", 100);
            Country c2 = new Country("Eng", 230);

            Country c3 = c1 + c2;

            Console.WriteLine("Union name: {0}", c3.Name);

            Country c4 = c1 > c2;
            Country c5 = c1 < c2;
            Country c6 = c1 == c2;
            Country c7 = c1 != c2;

            Console.ReadKey();
        }
    }
}
