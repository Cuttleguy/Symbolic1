using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class ComplexNumber<T> : IEquatable<ComplexNumber<T>>, 
        IEqualityOperators<ComplexNumber<T>, ComplexNumber<T>, bool> , 
        IFormattable, 
        IAdditionOperators<ComplexNumber<T>, ComplexNumber<T>, ComplexNumber<T>>,
        IAdditiveIdentity<ComplexNumber<T>,ComplexNumber<T>>,
        ISubtractionOperators<ComplexNumber<T>, ComplexNumber<T>, ComplexNumber<T>>,
        IMultiplyOperators<ComplexNumber<T>, ComplexNumber<T>, ComplexNumber<T>>,
        IMultiplicativeIdentity<ComplexNumber<T>,ComplexNumber<T>>,
        IDivisionOperators<ComplexNumber<T>, ComplexNumber<T>, ComplexNumber<T>>,
        IModulusOperators<ComplexNumber<T>, ComplexNumber<T>, ComplexNumber<T>>,
        IPowerFunctions<ComplexNumber<T>>,
        IRootFunctions<ComplexNumber<T>>,
        IUnaryNegationOperators<ComplexNumber<T>,ComplexNumber<T>>
        
        where T : 
        IEquatable<T>,
        IEqualityOperators<T,T,bool>, 
        IComparable<T>, 
        IFormattable, 
        IAdditionOperators<T,T,T>,
        IComparisonOperators<T,T,T>,
        ISubtractionOperators<T,T,T>,
        IMultiplyOperators<T,T,T>,
        IMultiplyOperators<T, int, T>,
        IMultiplyOperators<T, double, T>,
        IDivisionOperators<T,T,T>,
        IModulusOperators<T,T,T>,IPowerFunctions<T>,
        IRootFunctions<T>,
        IConvertible,
        INumberBase<T>,
        IUnaryNegationOperators<T,T>
    {
        public T real;
        public T imaginary;
        public ComplexNumber(T newReal, T newImaginary)
        {
            this.real = newReal; 
            this.imaginary = newImaginary;

        }
        public ComplexNumber(T newReal)
        {
            this.real = newReal;
            this.imaginary = T.Zero;

        }

        public static ComplexNumber<T> AdditiveIdentity => throw new NotImplementedException();

        public static ComplexNumber<T> MultiplicativeIdentity => throw new NotImplementedException();

        public static ComplexNumber<T> E => new ComplexNumber<T>(T.E);

        public static ComplexNumber<T> Pi => new ComplexNumber<T>(T.Pi);

        public static ComplexNumber<T> Tau => new ComplexNumber<T>(T.Tau);

        public static ComplexNumber<T> One => new ComplexNumber<T>(T.One);

        public static int Radix => 2;

        public static ComplexNumber<T> Zero => new ComplexNumber<T>(T.Zero);

        public static ComplexNumber<T> Abs(ComplexNumber<T> value)
        {
            return new ComplexNumber<T>(T.Sqrt(T.Pow(value.real, T.One * 2)+ T.Pow(value.imaginary, T.One * 2)));
        }

        public static ComplexNumber<T> Cbrt(ComplexNumber<T> x)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> Hypot(ComplexNumber<T> x, ComplexNumber<T> y)
        {
            throw new NotImplementedException();
        }

        public static bool IsCanonical(ComplexNumber<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsComplexNumber(ComplexNumber<T> value)
        {
            return true;
        }

        public static bool IsEvenInteger(ComplexNumber<T> value)
        {
            return false;
        }

        public static bool IsFinite(ComplexNumber<T> value)
        {
            return T.IsFinite(value.real)&&T.IsFinite(value.imaginary);
        }

        public static bool IsImaginaryNumber(ComplexNumber<T> value)
        {
            return value.real.Equals(T.Zero);
        }

        public static bool IsInfinity(ComplexNumber<T> value)
        {
            return !IsFinite(value);
        }

        public static bool IsInteger(ComplexNumber<T> value)
        {
            return false;
        }

        public static bool IsNaN(ComplexNumber<T> value)
        {
            return T.IsNaN(value.real)&&T.IsNaN(value.imaginary);
        }

        public static bool IsNegative(ComplexNumber<T> value)
        {
            return T.IsNegative(value.real);
        }

        public static bool IsNegativeInfinity(ComplexNumber<T> value)
        {
            return T.IsNegativeInfinity(value.real) && T.IsNegativeInfinity(value.imaginary);

        }

        public static bool IsNormal(ComplexNumber<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsOddInteger(ComplexNumber<T> value)
        {
            return false;
        }

        public static bool IsPositive(ComplexNumber<T> value)
        {
            return T.IsPositive(value.real);
        }

        public static bool IsPositiveInfinity(ComplexNumber<T> value)
        {
            return T.IsInfinity(value.real) && T.IsInfinity(value.imaginary);
        }

        public static bool IsRealNumber(ComplexNumber<T> value)
        {
            return value.imaginary.Equals(T.Zero);
        }

        public static bool IsSubnormal(ComplexNumber<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(ComplexNumber<T> value)
        {
            return value.Equals(Zero);
        }

        public static ComplexNumber<T> MaxMagnitude(ComplexNumber<T> x, ComplexNumber<T> y)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> MaxMagnitudeNumber(ComplexNumber<T> x, ComplexNumber<T> y)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> MinMagnitude(ComplexNumber<T> x, ComplexNumber<T> y)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> MinMagnitudeNumber(ComplexNumber<T> x, ComplexNumber<T> y)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> Pow(ComplexNumber<T> x, ComplexNumber<T> y)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> RootN(ComplexNumber<T> x, int n)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> Sqrt(ComplexNumber<T> x)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out ComplexNumber<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out ComplexNumber<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out ComplexNumber<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out ComplexNumber<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ComplexNumber<T>>.TryConvertFromChecked<TOther>(TOther value, out ComplexNumber<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ComplexNumber<T>>.TryConvertFromSaturating<TOther>(TOther value, out ComplexNumber<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ComplexNumber<T>>.TryConvertFromTruncating<TOther>(TOther value, out ComplexNumber<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ComplexNumber<T>>.TryConvertToChecked<TOther>(ComplexNumber<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ComplexNumber<T>>.TryConvertToSaturating<TOther>(ComplexNumber<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ComplexNumber<T>>.TryConvertToTruncating<TOther>(ComplexNumber<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        public bool Equals(ComplexNumber<T>? other)
        {
            if (other==null)
            {
                return false;
            }
            return real.Equals(other.real)
                && imaginary.Equals(other.imaginary); 
        }
             

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> operator +(ComplexNumber<T> value)
        {
            return value;
        }

        public static ComplexNumber<T> operator +(ComplexNumber<T> left, ComplexNumber<T> right)
        {
            return new ComplexNumber<T>(left.real+right.real,left.imaginary+right.imaginary);   
        }

        public static ComplexNumber<T> operator -(ComplexNumber<T> value)
        {
            return new ComplexNumber<T>(-value.real, -value.imaginary);
        }

        public static ComplexNumber<T> operator -(ComplexNumber<T> left, ComplexNumber<T> right)
        {
            return left + -right;
        }

        public static ComplexNumber<T> operator ++(ComplexNumber<T> value)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> operator --(ComplexNumber<T> value)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> operator *(ComplexNumber<T> left, ComplexNumber<T> right)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> operator /(ComplexNumber<T> left, ComplexNumber<T> right)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> operator %(ComplexNumber<T> left, ComplexNumber<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(ComplexNumber<T>? left, ComplexNumber<T>? right)
        {
            if (left == null) return false;

            return left.Equals(right);
        }

        public static bool operator !=(ComplexNumber<T>? left, ComplexNumber<T>? right)
        {
            if (left == null) return false;

            return !left.Equals(right);
        }
    }
}
