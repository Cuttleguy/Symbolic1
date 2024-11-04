using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Fraction : Rational<double>
    {
       /* public double numerator;
        public new double denominator;*/
        public Fraction(double newNumerator, double newDenominator) : base(newNumerator, newDenominator)
        {
            numerator = newNumerator;   
            denominator = newDenominator;
        }
        public double ToDouble()
        {
            
            return numerator / denominator;
        }

    }
}
