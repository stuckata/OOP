using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FractionCalculator
{
    public struct Fraction
    { 
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                Validators.AssertIntgerNumberIsInRange(value.ToString(), "Numerator");
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                Validators.AssertIntgerNumberIsInRange(value.ToString(), "Denominator");
                Validators.AssertDenominatorIsNotZero(value);
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            Fraction resultFraction = new Fraction();
            resultFraction.Denominator = fraction1.Denominator * fraction2.Denominator;
            resultFraction.Numerator = fraction1.Numerator * fraction2.Denominator + 
                fraction2.Numerator * fraction1.Denominator;

            return resultFraction;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            Fraction resultFraction = new Fraction();
            resultFraction.Denominator = fraction1.Denominator * fraction2.Denominator;
            resultFraction.Numerator = fraction1.Numerator * fraction2.Denominator -
                fraction2.Numerator * fraction1.Denominator;

            return resultFraction;
        }

        public override string ToString()
        {
            double result = this.Numerator / this.Denominator;

            return String.Format("{0}/{1} = {2}", this.Numerator, this.Denominator, result);
        }
    }
}
