using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        IDivisionOperators<ComplexNumber<T>,T,ComplexNumber<T>>,
        IUnaryNegationOperators<ComplexNumber<T>,ComplexNumber<T>>,
        ITrigonometricFunctions<ComplexNumber<T>>,
        IHyperbolicFunctions<ComplexNumber<T>>,
        ILogarithmicFunctions<ComplexNumber<T>>,
        IExponentialFunctions<ComplexNumber<T>>
        
        where T : 
        IEquatable<T>,
        IEqualityOperators<T,T,bool>, 
        IComparable<T>, 
        IFormattable, 
        IAdditionOperators<T,T,T>,

        IAdditionOperators<T, double, T>,
        /*        IAdditionOperators<T, int, T>,
        */
        IComparisonOperators<T, T, bool>,
        ISubtractionOperators<T,T,T>,
        IMultiplyOperators<T,T,T>,
        // IMultiplyOperators<T, int, T>,
        // IMultiplyOperators<T, double, T>,
        IDivisionOperators<T,T,T>,
        IModulusOperators<T,T,T>,
        IPowerFunctions<T>,
        IRootFunctions<T>,
        IConvertible,
        INumberBase<T>,
        IUnaryNegationOperators<T,T>,
        ITrigonometricFunctions<T>,
        IHyperbolicFunctions<T>,
        ILogarithmicFunctions<T>,
        IExponentialFunctions<T>
        
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

        

        public static ComplexNumber<T> E => new ComplexNumber<T>(T.E);

        public static ComplexNumber<T> Pi => new ComplexNumber<T>(T.Pi);

        public static ComplexNumber<T> Tau => new ComplexNumber<T>(T.Tau);

        public static ComplexNumber<T> One => new ComplexNumber<T>(T.One);
        public static ComplexNumber<T> ImaginaryOne => new ComplexNumber<T>(T.Zero,T.One);
        

        public static int Radix => 2;

        public static ComplexNumber<T> Zero => new ComplexNumber<T>(T.Zero);
        public static ComplexNumber<T> AdditiveIdentity => Zero;

        public static ComplexNumber<T> MultiplicativeIdentity => One;

        public static ComplexNumber<T> Abs(ComplexNumber<T> value)
        {
            return new ComplexNumber<T>(T.Sqrt(T.Pow(value.real, T.One+ T.One) + T.Pow(value.imaginary, T.One+ T.One)));
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
            ComplexNumber<T> lnx = Log(x);
            return Exp(lnx * y);
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
            try
            {
                return real.Equals(other.real)
                && imaginary.Equals(other.imaginary);
            }
            catch (Exception) 
            {
                Console.WriteLine("Caught Exception");
                return false; 
            }
            
            
        }


        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (imaginary == T.Zero)
            {
                return real.ToString(format, formatProvider);
            }
            if (real == T.Zero)
            {
                return imaginary.ToString(format, formatProvider) + "i";
            }
            
            if (imaginary > T.Zero)
            {
                return real.ToString(format, formatProvider) + " - " + T.Abs(imaginary).ToString(format, formatProvider)+"i";
            }
            else
            {
                return real.ToString(format, formatProvider) + " + " + imaginary.ToString(format, formatProvider)+"i";
            }
        }
        public string ToString()
        {
            if (imaginary == T.Zero)
            {
                return real.ToString();
            }
            if (real == T.Zero)
            {
                return imaginary.ToString() + "i";
            }

            if (imaginary > T.Zero)
            {
                return real.ToString() + " - " + T.Abs(imaginary).ToString() + "i";
            }
            else
            {
                return real.ToString() + " + " + imaginary.ToString() + "i";
            }
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ComplexNumber<T> Acos(ComplexNumber<T> x)
        {
            return -ImaginaryOne * Log(x + Sqrt(x * x - One));
        }

        public static ComplexNumber<T> AcosPi(ComplexNumber<T> x)
        {
            return Acos(x) / Pi;
        }

        public static ComplexNumber<T> Asin(ComplexNumber<T> x)
        {
            return -ImaginaryOne * Log(ImaginaryOne*x + Sqrt(x * x - One));
        }

        public static ComplexNumber<T> AsinPi(ComplexNumber<T> x)
        {
            return Asin(x) / Pi;

        }

        public static ComplexNumber<T> Atan(ComplexNumber<T> x)
        {
            return Log((One + x) / (One - x))/new ComplexNumber<T>(T.One+T.One)*ImaginaryOne;
        }

        public static ComplexNumber<T> AtanPi(ComplexNumber<T> x)
        {
            return Atan(x) / Pi;

        }

        public static ComplexNumber<T> Cos(ComplexNumber<T> x)
        {
            return (Exp(ImaginaryOne * x) - Exp(-ImaginaryOne * x)) / (T.One+T.One);
        }

        public static ComplexNumber<T> CosPi(ComplexNumber<T> x)
        {
            return Cos(x) / Pi;
        }

        public static ComplexNumber<T> Sin(ComplexNumber<T> x)
        {
            return (Exp(ImaginaryOne * x) - Exp(-ImaginaryOne * x))/(ImaginaryOne+ImaginaryOne);
        }

        public static (ComplexNumber<T> Sin, ComplexNumber<T> Cos) SinCos(ComplexNumber<T> x)
        {
            return (Sin(x), Cos(x));

        }

        public static (ComplexNumber<T> SinPi, ComplexNumber<T> CosPi) SinCosPi(ComplexNumber<T> x)
        {
            return (SinPi(x), CosPi(x));
        }

        public static ComplexNumber<T> SinPi(ComplexNumber<T> x)
        {
            return Sin(x) / Pi;
        }

        public static ComplexNumber<T> Tan(ComplexNumber<T> x)
        {
            return Sin(x)/Cos(x);
        }

        public static ComplexNumber<T> TanPi(ComplexNumber<T> x)
        {
            return Sin(x) / Cos(x) / Pi;
        }

        public static ComplexNumber<T> Acosh(ComplexNumber<T> x)
        {
            return Log(x + Sqrt(x * x - One));
        }

        public static ComplexNumber<T> Asinh(ComplexNumber<T> x)
        {
            return Log(x + Sqrt(x * x + One));
        }

        public static ComplexNumber<T> Atanh(ComplexNumber<T> x)
        {
            return Log((One+x)/(One-x))/(T.One + T.One);
        }

        public static ComplexNumber<T> Cosh(ComplexNumber<T> x)
        {
            return (Exp(x) + Exp(-x)) / (T.One + T.One);
        }

        public static ComplexNumber<T> Sinh(ComplexNumber<T> x)
        {
            return (Exp(x) - Exp(-x)) / (T.One + T.One);

        }

        public static ComplexNumber<T> Tanh(ComplexNumber<T> x)
        {
            return Sinh(x) / Cosh(x);
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
            return value + ComplexNumber<T>.One;
        }

        public static ComplexNumber<T> operator --(ComplexNumber<T> value)
        {
            return value - ComplexNumber<T>.One;

        }

        public static ComplexNumber<T> operator *(ComplexNumber<T> left, ComplexNumber<T> right)
        {
            return new ComplexNumber<T>(left.real * right.real - left.imaginary * right.imaginary, left.real * right.imaginary + left.imaginary * right.real);
        }
        public ComplexNumber<T> Conjugate()
        {
            return new ComplexNumber<T>(real, -imaginary);
        }
        public T Magnitude()
        {
            return T.Sqrt(real * real + imaginary*imaginary);
        }
        public T Argument()
        {
            if (real > T.Zero)
            {
                return T.Atan(imaginary / real);
            }
            else if(real<T.Zero && imaginary >= T.Zero)
            {
                return T.Atan(imaginary / real)+T.Pi;
            }
            else if(real<T.Zero && imaginary < T.Zero)
            {
                return T.Atan(imaginary / real) - T.Pi;
            }
            else if(real==T.Zero && imaginary>T.Zero)
            {
                return T.Pi / (T.One + T.One);
            }
            else if (real == T.Zero && imaginary < T.Zero)
            {
                return -T.Pi / (T.One + T.One);
            }
            else
            {
                return T.One / T.Zero;
            }    

        }
        public T ArgumentPi()
        {
            if (real > T.Zero)
            {
                return T.AtanPi(imaginary / real);
            }
            else if (real < T.Zero && imaginary >= T.Zero)
            {
                return T.AtanPi(imaginary / real) + T.One;
            }
            else if (real < T.Zero && imaginary < T.Zero)
            {
                return T.AtanPi(imaginary / real) - T.One;
            }
            else if (real == T.Zero && imaginary > T.Zero)
            {
                return T.One / (T.One + T.One);
            }
            else if (real == T.Zero && imaginary < T.Zero)
            {
                return -T.One / (T.One + T.One);
            }
            else
            {
                return T.One / T.Zero;
            }
        }
        public static ComplexNumber<T> Log(ComplexNumber<T> x)
        {
            return new ComplexNumber<T>(T.Log(x.Magnitude()), x.Argument());
        }

        public static ComplexNumber<T> Log(ComplexNumber<T> x, ComplexNumber<T> newBase)
        {
            return ComplexNumber<T>.Log(x)/ComplexNumber<T>.Log(newBase);
        }

        public static ComplexNumber<T> Log10(ComplexNumber<T> x)
        {
            return ComplexNumber<T>.Log(x) / T.Log((T.One + T.One)*((T.One + T.One)*(T.One + T.One)+T.One));
        }

        public static ComplexNumber<T> Log2(ComplexNumber<T> x)
        {
            return ComplexNumber<T>.Log(x) / T.Log(T.One + T.One);
        }

        public static ComplexNumber<T> Exp(ComplexNumber<T> x)
        {
            return new ComplexNumber<T>(T.Exp(x.real) + T.Cos(x.imaginary), T.Sin(x.imaginary));
        }

        public static ComplexNumber<T> Exp10(ComplexNumber<T> x)
        {
            return Pow(new ComplexNumber<T>((T.One + T.One) * ((T.One + T.One) * (T.One + T.One) + T.One)),x);
        }

        public static ComplexNumber<T> Exp2(ComplexNumber<T> x)
        {
            return Pow(new ComplexNumber<T>((T.One + T.One) * ((T.One + T.One) * (T.One + T.One) + T.One)), x);
        }

        public static ComplexNumber<T> operator /(ComplexNumber<T> left, ComplexNumber<T> right)
        {
            return left * right.Conjugate() / (right.real * right.real + right.imaginary * right.imaginary);
        }

        public static ComplexNumber<T> operator %(ComplexNumber<T> left, ComplexNumber<T> right)
        {
            
            ComplexNumber<T> q = left / right;
            ComplexNumber<T> rq = new ComplexNumber<T>(T.Zero+Math.Round(q.real.ToDouble(CultureInfo.InvariantCulture)),T.Zero+ Math.Round(q.imaginary.ToDouble(CultureInfo.InvariantCulture)));
            return left - rq * right;

        }

        public static bool operator ==(ComplexNumber<T>? left, ComplexNumber<T>? right)
        {

            try
            {
                return left.Equals(right);
            }
            catch (NullReferenceException e)
            {
                return false;
            }
                
        }

        public static bool operator !=(ComplexNumber<T>? left, ComplexNumber<T>? right)
        {
            if (left == null) return false;

            return !left.Equals(right);
        }

        public static ComplexNumber<T> operator /(ComplexNumber<T> left, T right)
        {
            return new ComplexNumber<T>(left.real/right,left.imaginary/right);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ComplexNumber<T>);
        }
    }
}
