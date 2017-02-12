using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFraction
{
    /// <summary>
    /// Develop a class Fraction, representing simple fraction. In the class provide two fields: the numerator and denominator of the fraction. 
    /// Perform overload the following operators: +, -, *, /. 
    /// Arithmetic operations and comparison is performed in accordance with the rules of working with fractions.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(9, 11);
            Fraction f2 = new Fraction(6, 7);

            Fraction f3 = f1 + f2;
            Fraction f4 = f1 * f2;
            Fraction f5 = f1 + 15;
            Fraction f6 = f2 * 8;
            Fraction f7 = f1 - f2;
            Fraction f8 = f1 / f2;
            Fraction f9 = f1 - 15;
            Fraction f11 = f2 / 8;

            Console.WriteLine("+f: " + f3.numerator + "/" + f3.denominator);
            Console.WriteLine("*f: " + f4.numerator + "/" + f4.denominator);
            Console.WriteLine("+n: " + f5.numerator + "/" + f5.denominator);
            Console.WriteLine("*n: " + f6.numerator + "/" + f6.denominator);
            Console.WriteLine("-f: " + f7.numerator + "/" + f7.denominator);
            Console.WriteLine("/f: " + f8.numerator + "/" + f8.denominator);
            Console.WriteLine("-n: " + f9.numerator + "/" + f9.denominator);
            Console.WriteLine("/n: " + f11.numerator + "/" + f11.denominator);

            Console.ReadKey();
        }
    }
}
