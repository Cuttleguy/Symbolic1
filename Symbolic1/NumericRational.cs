using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class NumericRational<T> : Rational<T>,IComparable<Rational<T>>,IComparisonOperators<NumericRational<T>, NumericRational<T>, bool> where T : IEquatable<T>, IConvertible, IFormattable, IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, T, T>, IComparisonOperators<T, T, bool>, IModulusOperators<T, T, T>, IUnaryNegationOperators<T, T>, IDivisionOperators<T, T, T
    {

        public NumericRational(T newNumerator, T newDenominator) : base(newNumerator, newDenominator)
        {
        }

        public int CompareTo(Rational<T> other)
        {
            if(this.Equals(other)) return 0;
            return this - other;
        }

        public static bool operator ==(NumericRational<T>? left, NumericRational<T>? right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(NumericRational<T>? left, NumericRational<T>? right)
        {
            return !left.Equals(right);

        }
        

        public static bool operator <(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator <=(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >=(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }
    }
}
