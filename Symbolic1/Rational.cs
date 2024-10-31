using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
namespace Symbolic1
{
    public class Rational<T> : IEquatable<Rational<T>>,IUnaryNegationOperators<Rational<T>, Rational<T>>,IModulusOperators<Rational<T>, Rational<T>, Rational<T>>,IEqualityOperators<Rational<T>,Rational<T>,bool>,IFormattable,IDivisionOperators<Rational<T>, Rational<T>, Rational<T>>,IAdditionOperators<Rational<T>, Rational<T>, Rational<T>>, ISubtractionOperators<Rational<T>, Rational<T>, Rational<T>>,IMultiplyOperators<Rational<T>, Rational<T>, Rational<T>> where T : IEquatable<T>, IFormattable, IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, T, T>,IComparisonOperators<T,T,bool>,IModulusOperators<T,T,T> ,IUnaryNegationOperators<T,T>,IDivisionOperators<T, T, T>
    {
        public T numerator;
        public T denominator;
        public Rational(T newNumerator,T newDenominator)
        {
            T gcd = GCF(newNumerator, newDenominator);
            numerator = newNumerator / gcd;
            denominator = newDenominator / gcd;
        }
        public static T  GCF(T input, T other)
        {
            if (other.Equals(0))
            {
                return input;
            }
            return GCF(other, input%other);
        }
        //public int CompareTo(Rational<T> other)
        //{
        //    if(this.Equals(other)) return 0;
        //    return this - other;
        //}


        public bool Equals(Rational<T> other)
        {
            return numerator.Equals(other.numerator) &&
                denominator.Equals(other.denominator);
        }
        public static implicit operator double(Rational<T> rational)
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            return (rational.numerator / rational.denominator).ToDouble(cultureInfo);
        }
        public static implicit operator int(Rational<T> rational)
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            return (rational.numerator / rational.denominator).ToInt32(cultureInfo);
        }
        
        public override string ToString()
        {
            return "(" + numerator.ToString() + ") / (" + denominator.ToString() + ")";

        }
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            return "("+numerator.ToString(format, formatProvider)+ ") / (" + denominator.ToString(format, formatProvider)+")"; 
        }

        public static Rational<T> operator +(Rational<T> left, Rational<T> right)
        {
            return new Rational<T>(left.numerator*right.denominator+right.numerator*left.denominator,left.denominator*right.denominator);
        }

        public static Rational<T> operator -(Rational<T> left, Rational<T> right)
        {
            return left + -right;
        }

        public static Rational<T> operator *(Rational<T> left, Rational<T> right)
        {
            return new Rational<T>(left.numerator*right.numerator,left.denominator*right.denominator);
        }

        public static Rational<T> operator /(Rational<T> left, Rational<T> right)
        {
            return new Rational<T>(left.numerator*right.denominator,left.denominator*right.numerator);
        }

        public static Rational<T> operator %(Rational<T> left, Rational<T> right)
        {
            // Convert both fractions to a common denominator
            T commonDenominator = left.denominator * right.denominator;
            T numeratorA = left.numerator * right.denominator;
            T numeratorB = left.numerator * right.denominator;

            // Apply modulus to the numerators
            T resultNumerator = numeratorA % numeratorB;
            return new Rational<T>(resultNumerator, commonDenominator);
        }

        //public static bool operator >(Rational<T> left, Rational<T> right)
        //{
        //    return left.CompareTo(right) > 0;
        //}

        //public static bool operator >=(Rational<T> left, Rational<T> right)
        //{
        //    return left.CompareTo(right) >= 0;
        //}

        //public static bool operator <(Rational<T> left, Rational<T> right)
        //{
        //    return left.CompareTo(right) < 0;
        //}

        //public static bool operator <=(Rational<T> left, Rational<T> right)
        //{
        //    return left.CompareTo(right) <= 0;
        //}

        public static bool operator ==(Rational<T> left, Rational<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Rational<T> left, Rational<T> right)
        {
            return !left.Equals(right);
        }

        public static Rational<T> operator -(Rational<T> value)
        {
            return new Rational<T>(-value.numerator,value.denominator);
        }
    }
}
