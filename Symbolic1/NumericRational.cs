/*using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class NumericRational<T> : Rational<T>, IComparable<NumericRational<T>>,
        IConvertible,
        IEquatable<Rational<T>>,
        IComparisonOperators<NumericRational<T>, NumericRational<T>, bool>,
        IEquatable<NumericRational<T>>,
        IUnaryNegationOperators<NumericRational<T>, NumericRational<T>>,
        IModulusOperators<NumericRational<T>, NumericRational<T>, NumericRational<T>>,
        IEqualityOperators<NumericRational<T>, NumericRational<T>, bool>,
        IFormattable,
        IDivisionOperators<NumericRational<T>, NumericRational<T>, NumericRational<T>>,
        IAdditionOperators<NumericRational<T>, NumericRational<T>, NumericRational<T>>,
        ISubtractionOperators<NumericRational<T>, NumericRational<T>, NumericRational<T>>,
        IMultiplyOperators<NumericRational<T>, NumericRational<T>, NumericRational<T>>,
        IPowerFunctions<NumericRational<T>>,
        INumberBase<NumericRational<T>>,
        IRootFunctions<NumericRational<T>>,
        IExponentialFunctions<NumericRational<T>>,
        ILogarithmicFunctions<NumericRational<T>>,
        ITrigonometricFunctions<NumericRational<T>>,
        IHyperbolicFunctions<NumericRational<T>>,
        where T : 
        INumberBase<T>,
        ITrigonometricFunctions<T>,
        IExponentialFunctions<T>,
        ILogarithmicFunctions<T>,
        IRootFunctions<T>,
        IPowerFunctions<T>,
        IHyperbolicFunctions<T>,IEquatable<T>, IConvertible, IFormattable, IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, T, T>, IComparisonOperators<T, T, bool>, IModulusOperators<T, T, T>, IUnaryNegationOperators<T, T>, IDivisionOperators<T, T, T>
    {
        static NumericRational<T> INumberBase<NumericRational<T>>.One => throw new NotImplementedException();

        static NumericRational<T> INumberBase<NumericRational<T>>.Zero => throw new NotImplementedException();

        static NumericRational<T> IAdditiveIdentity<NumericRational<T>, NumericRational<T>>.AdditiveIdentity => throw new NotImplementedException();

        static NumericRational<T> IMultiplicativeIdentity<NumericRational<T>, NumericRational<T>>.MultiplicativeIdentity => throw new NotImplementedException();

        static NumericRational<T> IFloatingPointConstants<NumericRational<T>>.E => throw new NotImplementedException();

        static NumericRational<T> IFloatingPointConstants<NumericRational<T>>.Pi => throw new NotImplementedException();

        static NumericRational<T> IFloatingPointConstants<NumericRational<T>>.Tau => throw new NotImplementedException();

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

        public static NumericRational<T> operator -(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> operator %(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> operator /(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> operator +(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> operator --(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> operator ++(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> operator *(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> operator -(NumericRational<T> left, NumericRational<T> right)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> operator +(NumericRational<T> value)
        {
            throw new NotImplementedException();
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

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider? provider)
        {
            return (numerator / denominator).ToDecimal(provider);
        }

        public double ToDouble(IFormatProvider? provider)
        {
            return (numerator / denominator).ToDouble(provider);
        }

        public short ToInt16(IFormatProvider? provider)
        {
            return (numerator / denominator).ToInt16(provider);
        }

        public int ToInt32(IFormatProvider? provider)
        {
            return (numerator / denominator).ToInt32(provider);
        }

        public long ToInt64(IFormatProvider? provider)
        {
            return (numerator / denominator).ToInt64(provider);
        }

        public sbyte ToSByte(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider? provider)
        {
            return (numerator / denominator).ToSingle(provider);
        }

        public string ToString(IFormatProvider? provider)
        {
            return "("+numerator.ToString(provider) + ") / (" + denominator.ToString(provider)+")";
        }

        public object ToType(Type conversionType, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider? provider)
        {
            return (numerator / denominator).ToUInt16(provider);

        }

        public uint ToUInt32(IFormatProvider? provider)
        {
            return (numerator / denominator).ToUInt32(provider);
        }

        public ulong ToUInt64(IFormatProvider? provider)
        {
            return (numerator / denominator).ToUInt64(provider);
        }

        public bool Equals(NumericRational<T>? other)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Pow(NumericRational<T> x, NumericRational<T> y)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Abs(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsCanonical(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsComplexNumber(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsEvenInteger(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsFinite(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsImaginaryNumber(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInfinity(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInteger(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNaN(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegative(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegativeInfinity(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNormal(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsOddInteger(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositive(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositiveInfinity(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsRealNumber(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsSubnormal(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(NumericRational<T> value)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> MaxMagnitude(NumericRational<T> x, NumericRational<T> y)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> MaxMagnitudeNumber(NumericRational<T> x, NumericRational<T> y)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> MinMagnitude(NumericRational<T> x, NumericRational<T> y)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> MinMagnitudeNumber(NumericRational<T> x, NumericRational<T> y)
        {
            throw new NotImplementedException();
        }

        static NumericRational<T> INumberBase<NumericRational<T>>.Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        static NumericRational<T> INumberBase<NumericRational<T>>.Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out NumericRational<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out NumericRational<T> result)
        {
            throw new NotImplementedException();
        }

        static NumericRational<T> ISpanParsable<NumericRational<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out NumericRational<T> result)
        {
            throw new NotImplementedException();
        }

        static NumericRational<T> IParsable<NumericRational<T>>.Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out NumericRational<T> result)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Cbrt(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Hypot(NumericRational<T> x, NumericRational<T> y)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> RootN(NumericRational<T> x, int n)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Sqrt(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Exp(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Exp10(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Exp2(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Log(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Log(NumericRational<T> x, NumericRational<T> newBase)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Log10(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Log2(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Acos(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> AcosPi(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Asin(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> AsinPi(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Atan(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> AtanPi(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Cos(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> CosPi(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Sin(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static (NumericRational<T> Sin, NumericRational<T> Cos) SinCos(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static (NumericRational<T> SinPi, NumericRational<T> CosPi) SinCosPi(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> SinPi(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Tan(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> TanPi(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Acosh(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Asinh(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Atanh(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Cosh(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Sinh(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        public static NumericRational<T> Tanh(NumericRational<T> x)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<NumericRational<T>>.TryConvertFromChecked<TOther>(TOther value, out NumericRational<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<NumericRational<T>>.TryConvertFromSaturating<TOther>(TOther value, out NumericRational<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<NumericRational<T>>.TryConvertFromTruncating<TOther>(TOther value, out NumericRational<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<NumericRational<T>>.TryConvertToChecked<TOther>(NumericRational<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<NumericRational<T>>.TryConvertToSaturating<TOther>(NumericRational<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<NumericRational<T>>.TryConvertToTruncating<TOther>(NumericRational<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }
    }
}
*/