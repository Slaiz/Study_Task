using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country
{
    class Country
    {
        private string name;
        private long numbPeople;
        private int square;

        public Country()
        {

        }

        public Country(string name)
        {
            Name = name;
        }

        public Country(string name, long numbPeople)
        {
            Name = name;
            NumbPeople = numbPeople;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
            }
        }
        public long NumbPeople
        {
            get { return numbPeople; }
            set
            {
                if (value > 0)
                    numbPeople = value;
            }
        }
        public int Square
        {
            get { return square; }
            set
            {
                if (value > 0)
                    square = value;
            }
        }

        public static Country operator +(Country c1, Country c2)
        {
            return new Country(c1.Name + "-" + c2.Name, c1.numbPeople + c2.numbPeople);
        }

        public static Country operator >(Country c1, Country c2)
        {
            if (c1.square > c2.square)
            { Console.WriteLine("{0} are grate than {1} ", c1.Name, c2.Name); return c1; }
            else { Console.WriteLine("{0} are grate than {1} ", c2.Name, c1.Name); return c2; }

        }

        public static Country operator <(Country c1, Country c2)
        {
            if (c1.square < c2.square)
            { Console.WriteLine("{0} are small than {1} ", c2.Name, c1.Name); return c1; }
            else { Console.WriteLine("{0} are small than {1} ", c1.Name, c2.Name); return c2; }
        }

        public static Country operator ==(Country c1, Country c2)
        {
            if (c1.NumbPeople == c2.numbPeople)
            { Console.WriteLine("In {0} and {1} are similar numbPeople", c1.Name, c2.Name); return c1; }
            else return null;
        }

        public static Country operator !=(Country c1, Country c2)
        {
            if (c1.NumbPeople != c2.numbPeople)
            { Console.WriteLine("In {0} and {1} are not similar numbPeople", c1.Name, c2.Name); return c1; }
            else return null;
        }

    }
}
