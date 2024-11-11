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
using System.Diagnostics.CodeAnalysis;
namespace Symbolic1
{
    public class Rational<T> : 
        IEquatable<Rational<T>>,
        IUnaryNegationOperators<Rational<T>, Rational<T>>,
        IModulusOperators<Rational<T>, Rational<T>, Rational<T>>,
        IEqualityOperators<Rational<T>,Rational<T>,bool>,
        IFormattable,
        IPowerFunctions<Rational<T>>,
        IDivisionOperators<Rational<T>, Rational<T>, Rational<T>>,
        IAdditionOperators<Rational<T>, Rational<T>, Rational<T>>, 
        ISubtractionOperators<Rational<T>, Rational<T>, Rational<T>>,
        IMultiplyOperators<Rational<T>, Rational<T>, Rational<T>> ,
        IRootFunctions<Rational<T>>,
        IExponentialFunctions<Rational<T>>,
        ILogarithmicFunctions<Rational<T>>,
        ITrigonometricFunctions<Rational<T>>,
        IHyperbolicFunctions<Rational<T>>,
        IConvertible,
        IAdditionOperators<Rational<T>,T,Rational<T>>
        
        where T : IEquatable<T>, 
        IFormattable, 
        IAdditionOperators<T, T, T>, 
        ISubtractionOperators<T, T, T>, 
        IMultiplyOperators<T, T, T>,
        IModulusOperators<T,T,T>,
        IUnaryNegationOperators<T,T>,
        IDivisionOperators<T, T, T>,
        INumberBase<T>,
        IPowerFunctions<T>,
        IRootFunctions<T>,
        ITrigonometricFunctions<T>,
        IHyperbolicFunctions<T>,
        ILogarithmicFunctions<T>,
        IExponentialFunctions<T>,
        IAdditionOperators<T,double,T>,
        IConvertible
    {
        public T numerator;
        public T denominator;

        public static Rational<T> One => new Rational<T>(T.One, T.One);

        public static int Radix => 2;

        public static Rational<T> Zero => new Rational<T>(T.Zero, T.One);

        public static Rational<T> AdditiveIdentity => Zero;

        public static Rational<T> MultiplicativeIdentity => One;

        public static Rational<T> E => new Rational<T> (T.E, T.One);

        public static Rational<T> Pi => new Rational<T>(T.Pi, T.One);

        public static Rational<T> Tau => new Rational<T>(T.Tau,T.One);

        public Rational(T newNumerator,T newDenominator)
        {
            T gcd = GCF(newNumerator, newDenominator);
            numerator = newNumerator / gcd;
            denominator = newDenominator / gcd;
        }
        public static T  GCF(T input, T other)
        {
            if (T.IsZero(other))
            {
                return input;
            }
            return GCF(other, input%other);
        }
        //public int CompareTo(Rational<T> other)
        //{
        //    if(this.Equals(other)) return 0;
        //    return this - other;
        //    return this - other;
        //}


        public bool Equals(Rational<T> other)
        {
            return numerator.Equals(other.numerator) &&
                denominator.Equals(other.denominator);
        }
        /*public static implicit operator double(Rational<T> rational)
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            return (rational.numerator / rational.denominator).ToDouble(cultureInfo);
        }
        public static implicit operator int(Rational<T> rational)
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            return (rational.numerator / rational.denominator).ToInt32(cultureInfo);
        }*/
        
        public override string ToString()
        {
            return numerator.ToString() + " / " + denominator.ToString();

        }
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            return numerator.ToString(format, formatProvider)+ " / " + denominator.ToString(format, formatProvider); 
        }

        public static Rational<T> Pow(Rational<T> x, Rational<T> y)
        {
            return Exp(y * Log(x));
        }

        public static Rational<T> Abs(Rational<T> value)
        {
            return new Rational<T>(T.Abs(value.numerator), T.Abs(value.denominator));
        }

        public static bool IsCanonical(Rational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsComplexNumber(Rational<T> value)
        {
            return T.IsComplexNumber(value.numerator);
        }

        public static bool IsEvenInteger(Rational<T> value)
        {
            return T.IsEvenInteger(value.numerator)&&value.denominator==T.One;
        }

        public static bool IsFinite(Rational<T> value)
        {
            return (T.IsFinite(value.numerator) && T.IsFinite(value.denominator));
        }

        public static bool IsImaginaryNumber(Rational<T> value)
        {
            return (T.IsImaginaryNumber(value.numerator)&& value.denominator==T.One);
        }

        public static bool IsInfinity(Rational<T> value)
        {
            return T.IsInfinity(value.numerator);
        }

        public static bool IsInteger(Rational<T> value)
        {
            return T.IsInteger(value.numerator) && value.denominator == T.One;
        }

        public static bool IsNaN(Rational<T> value)
        {
            return T.IsNaN(value.numerator) || T.IsNaN(value.denominator);
        }

        public static bool IsNegative(Rational<T> value)
        {
            return T.IsNegative(value.numerator) ^ T.IsNegative(value.denominator);
        }

        public static bool IsNegativeInfinity(Rational<T> value)
        {
            return T.IsNegativeInfinity(value.numerator);
        }

        public static bool IsNormal(Rational<T> value)
        {
            return true;
        }

        public static bool IsOddInteger(Rational<T> value)
        {
            return T.IsOddInteger(value.numerator) && value.denominator == T.One;
        }
        public static bool IsPositive(Rational<T> value)
        {
            return !IsNegative(value) && !IsZero(value);
        }

        public static bool IsPositiveInfinity(Rational<T> value)
        {
            return T.IsPositiveInfinity(value.numerator);

        }

        public static bool IsRealNumber(Rational<T> value)
        {
            return T.IsRealNumber(value.numerator) && T.IsRealNumber(value.denominator);
        }

        public static bool IsSubnormal(Rational<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(Rational<T> value)
        {
            return T.IsZero(value.numerator) && ! T.IsZero(value.denominator);  
        }

        public static Rational<T> MaxMagnitude(Rational<T> x, Rational<T> y)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> MaxMagnitudeNumber(Rational<T> x, Rational<T> y)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> MinMagnitude(Rational<T> x, Rational<T> y)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> MinMagnitudeNumber(Rational<T> x, Rational<T> y)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Rational<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Rational<T> result)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Rational<T> result)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Rational<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Rational<T>>.TryConvertFromChecked<TOther>(TOther value, out Rational<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Rational<T>>.TryConvertFromSaturating<TOther>(TOther value, out Rational<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Rational<T>>.TryConvertFromTruncating<TOther>(TOther value, out Rational<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Rational<T>>.TryConvertToChecked<TOther>(Rational<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Rational<T>>.TryConvertToSaturating<TOther>(Rational<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Rational<T>>.TryConvertToTruncating<TOther>(Rational<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> Cbrt(Rational<T> x)
        {
            return new Rational<T>(T.Cbrt(x.numerator), T.Cbrt(x.denominator)); 
        }

        public static Rational<T> Hypot(Rational<T> x, Rational<T> y)
        {
            return Sqrt(x * x + y * y);
        }

        public static Rational<T> RootN(Rational<T> x, int n)
        {
            return new Rational<T>(T.RootN(x.numerator,n), T.RootN(x.denominator,n));

        }

        public static Rational<T> Sqrt(Rational<T> x)
        {
            return new Rational<T>(T.Sqrt(x.numerator), T.Sqrt(x.denominator));
        }

        public static Rational<T> Exp(Rational<T> x)
        {
            
            return new Rational<T>(T.Exp(x.numerator/x.denominator),T.One);
        }

        public static Rational<T> Exp10(Rational<T> x)
        {
            return Pow(new Rational<T>((T.One + T.One) * ((T.One + T.One) + (T.One * T.One) + T.One), T.One),x);
        }

        public static Rational<T> Exp2(Rational<T> x)
        {
            return Pow(new Rational<T>((T.One + T.One), T.One), x);
        }

        public static Rational<T> Acos(Rational<T> x)
        {
            return new Rational<T>(T.Acos(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> AcosPi(Rational<T> x)
        {
            return new Rational<T>(T.AcosPi(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Asin(Rational<T> x)
        {
            return new Rational<T>(T.Asin(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> AsinPi(Rational<T> x)
        {
            return new Rational<T>(T.AsinPi(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Atan(Rational<T> x)
        {
            return new Rational<T>(T.Atan(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> AtanPi(Rational<T> x)
        {
            return new Rational<T>(T.AtanPi(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Cos(Rational<T> x)
        {
            return new Rational<T>(T.Cos(x.numerator / x.denominator), T.One);

        }

        public static Rational<T> CosPi(Rational<T> x)
        {
            return new Rational<T>(T.CosPi(x.numerator / x.denominator), T.One);

        }

        public static Rational<T> Sin(Rational<T> x)
        {
            return new Rational<T>(T.Sin(x.numerator / x.denominator), T.One);

        }

        public static (Rational<T> Sin, Rational<T> Cos) SinCos(Rational<T> x)
        {
            return (new Rational<T>(T.Sin(x.numerator / x.denominator), T.One), new Rational<T>(T.Cos(x.numerator / x.denominator), T.One));

        }

        public static (Rational<T> SinPi, Rational<T> CosPi) SinCosPi(Rational<T> x)
        {
            return (new Rational<T>(T.SinPi(x.numerator / x.denominator), T.One), new Rational<T>(T.CosPi(x.numerator / x.denominator), T.One));
        }

        public static Rational<T> SinPi(Rational<T> x)
        {
            return new Rational<T>(T.SinPi(x.numerator / x.denominator), T.One);

        }

        public static Rational<T> Tan(Rational<T> x)
        {
            return new Rational<T>(T.Tan(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> TanPi(Rational<T> x)
        {
            return new Rational<T>(T.TanPi(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Acosh(Rational<T> x)
        {
            return new Rational<T>(T.Acosh(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Asinh(Rational<T> x)
        {
            return new Rational<T>(T.Asinh(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Atanh(Rational<T> x)
        {
            return new Rational<T>(T.Atanh(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Cosh(Rational<T> x)
        {
            return new Rational<T>(T.Cosh(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Sinh(Rational<T> x)
        {
            return new Rational<T>(T.Sinh(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Tanh(Rational<T> x)
        {
            return new Rational<T>(T.Tanh(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Log(Rational<T> x)
        {
            return new Rational<T>(T.Log(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Log(Rational<T> x, Rational<T> newBase)
        {
            return new Rational<T>(T.Log(x.numerator / x.denominator,newBase.numerator/newBase.denominator), T.One);

        }

        public static Rational<T> Log10(Rational<T> x)
        {
            return new Rational<T>(T.Log10(x.numerator / x.denominator), T.One);
        }

        public static Rational<T> Log2(Rational<T> x)
        {
            return new Rational<T>(T.Log2(x.numerator / x.denominator), T.One);
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
            return (numerator / denominator).ToSByte(provider);
        }

        public float ToSingle(IFormatProvider? provider)
        {
            return (numerator / denominator).ToSingle(provider);
        }

        public string ToString(IFormatProvider? provider)
        {
            return numerator.ToString(provider)+" / "+denominator.ToString(provider); 
        }

        public object ToType(Type conversionType, IFormatProvider? provider)
        {
            return (numerator / denominator).ToType(conversionType,provider);
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

        public static Rational<T> operator --(Rational<T> value)
        {
            return value - One;
        }

        public static Rational<T> operator ++(Rational<T> value)
        {
            return value + One;
        }

        public static Rational<T> operator +(Rational<T> value)
        {
            return value;
        }

        public static Rational<T> operator +(Rational<T> left, T right)
        {
            return left + new Rational<T>(right, T.One);
        }
    }
}
