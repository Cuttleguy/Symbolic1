/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Fraction : NumericRational<double>,IEquatable<Fraction> 
    {
       *//* public double numerator;
        public new double denominator;*//*
        public Fraction(double newNumerator, double newDenominator) : base(newNumerator, newDenominator)
        {
           
        }

        public bool Equals(Fraction? other)
        {
            if(other== null) throw new ArgumentNullException("other");
            return numerator == other.numerator && denominator == other.denominator;
        }

        public double ToDouble()
        {
            
            return numerator / denominator;
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction(left.numerator * right.denominator + right.numerator * left.denominator, left.denominator * right.denominator);

        }

        public static Fraction operator -(Fraction value)
        {
            return new Fraction(-value.numerator, -value.denominator);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            return left + -right;

        }

        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.numerator*right.numerator, left.denominator*right.denominator);
        }
        public static Fraction
        *//*public static Fraction operator +(Fraction left, Fraction right)
        {
            
        }*//*

        public static bool operator ==(Fraction? left, Fraction? right)
        {
            if(left==null) throw new ArgumentNullException("left");
            return left.Equals(right);
        }

        public static bool operator !=(Fraction? left, Fraction? right)
        {
            if (left == null) throw new ArgumentException("left");
            return !left.Equals(right);
        }
    }
}
*/