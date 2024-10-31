using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Symbolic1
{
    public struct Rational<T> : IEquatable<Rational<T>>,IComparable<Rational<T>>,IFormattable,IAdditionOperators<Rational<T>, Rational<T>, Rational<T>>, ISubtractionOperators<Rational<T>, Rational<T>, Rational<T>>,IMultiplyOperators<Rational<T>, Rational<T>, Rational<T>> where T : IEquatable<T>, IComparable<T>, IFormattable, IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, T, T>, IDivisionOperators<T, T, T>
    {
        public T numerator;
        public T denominator;
        public int CompareTo(Rational<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Rational<T> other)
        {
            return numerator.Equals(other.numerator) &&
                denominator.Equals(other.denominator);
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> operator +(Rational<T> left, Rational<T> right)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> operator -(Rational<T> left, Rational<T> right)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> operator *(Rational<T> left, Rational<T> right)
        {
            throw new NotImplementedException();
        }
    }
}
