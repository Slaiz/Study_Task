using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacStruc
{
    struct Zodiac
    {
        public string name;
        public string surname;
        public char zodiacSign;
        public int[] dateBirth;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zodiac[] man = new Zodiac[3];

            for (int i = 0; i < man.Length; i++)
            {
                Console.WriteLine("Write name {0} man", i+1);
                man[i].name = Console.ReadLine();

                Console.WriteLine("Write surname {0} man", i+1);
                man[i].surname = Console.ReadLine();

                Console.WriteLine("Write Zodiac Sign {0} man", i+1);
                man[i].zodiacSign = Char.Parse(Console.ReadLine());

                man[i].dateBirth = new int[3];

                Console.WriteLine("Write day date birth {0} man", i+1);
                man[i].dateBirth[0] = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Write mouth date birth {0} man", i+1);
                man[i].dateBirth[1] = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Write year date birth {0} man", i + 1);
                man[i].dateBirth[2] = Int32.Parse(Console.ReadLine());
            }

            Console.Clear();

            int k;

            Console.Write("Write id man:");
            k = Int32.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Name: {0}\nSurname: {1}\nZodiac Sign: {2}\nDate Birth: {3}", man[k].name, man[k].surname, man[k].zodiacSign, 
                man[k].dateBirth[0].ToString() + man[k].dateBirth[1].ToString() + man[k].dateBirth[2].ToString());

            Console.ReadLine();
        }
    }
}
