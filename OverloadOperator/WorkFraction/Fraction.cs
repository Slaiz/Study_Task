using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFraction
{
    class Fraction
    {
        public double numerator;
        public double denominator;

        public Fraction(double numerator, double denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator; 
        }

        public static Fraction operator +(Fraction f1, int n)
        {
            return new Fraction(f1.numerator + n, f1.denominator);
        }

        public static Fraction operator *(Fraction f1, int n)
        {
            return new Fraction(f1.numerator * n, f1.denominator);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator *  f2.numerator, f1.denominator * f2.denominator);
        }


        public static Fraction operator -(Fraction f1, int n)
        {
            return new Fraction(f1.numerator - n, f1.denominator);
        }

        public static Fraction operator /(Fraction f1, int n)
        {
            return new Fraction(f1.numerator, f1.denominator * n);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator * f2.denominator - f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator * f2.denominator, f1.denominator * f2.numerator);
        }
    }
}
