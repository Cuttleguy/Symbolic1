using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class NumericRational<T> : Rational<T>, IComparable<NumericRational<T>>,
        IEquatable<Rational<T>>,
        IComparisonOperators<NumericRational<T>, NumericRational<T>, bool> where T : 
        INumberBase<T>,
        ITrigonometricFunctions<T>,
        IExponentialFunctions<T>,
        ILogarithmicFunctions<T>,
        IRootFunctions<T>,
        IPowerFunctions<T>,
        IHyperbolicFunctions<T>,IEquatable<T>, IConvertible, IFormattable, IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, T, T>, IComparisonOperators<T, T, bool>, IModulusOperators<T, T, T>, IUnaryNegationOperators<T, T>, IDivisionOperators<T, T, T>
    {

        public NumericRational(T newNumerator, T newDenominator) : base(newNumerator, newDenominator)
        {
        }

        public int CompareTo(NumericRational<T> other)
        {
            if (this.Equals(other)) return 0;
            if (this > other) return 1; else return -1;
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
            return left.numerator * right.denominator < right.numerator * left.denominator;
        }

        public static bool operator >(NumericRational<T> left, NumericRational<T> right)
        {
            return left.numerator * right.denominator > right.numerator * left.denominator;
        }

        public static bool operator <=(NumericRational<T> left, NumericRational<T> right)
        {
            return left.numerator * right.denominator <= right.numerator * left.denominator;
        }

        public static bool operator >=(NumericRational<T> left, NumericRational<T> right)
        {
            return left.numerator * right.denominator >= right.numerator * left.denominator;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
