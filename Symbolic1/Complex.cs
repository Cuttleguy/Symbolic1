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
    public class Complex<T> : IEquatable<Complex<T>>, 
        IEqualityOperators<Complex<T>, Complex<T>, bool> , 
        IFormattable, 
        IAdditionOperators<Complex<T>, Complex<T>, Complex<T>>,
        IAdditiveIdentity<Complex<T>,Complex<T>>,
        ISubtractionOperators<Complex<T>, Complex<T>, Complex<T>>,
        IMultiplyOperators<Complex<T>, Complex<T>, Complex<T>>,
        IMultiplicativeIdentity<Complex<T>,Complex<T>>,
        IDivisionOperators<Complex<T>, Complex<T>, Complex<T>>,
        IModulusOperators<Complex<T>, Complex<T>, Complex<T>>,
        IPowerFunctions<Complex<T>>,
        IRootFunctions<Complex<T>>,
        IDivisionOperators<Complex<T>,T,Complex<T>>,
        IUnaryNegationOperators<Complex<T>,Complex<T>>,
        ITrigonometricFunctions<Complex<T>>,
        IHyperbolicFunctions<Complex<T>>,
        ILogarithmicFunctions<Complex<T>>,
        IExponentialFunctions<Complex<T>>
        
        where T : 
        IEquatable<T>,
        IEqualityOperators<T,T,bool>, 
/*        IComparable<T>, 
*/        IFormattable, 
        IAdditionOperators<T,T,T>,

        IAdditionOperators<T, double, T>,
        /*        IAdditionOperators<T, int, T>,
        */
/*        IComparisonOperators<T, T, bool>,
*/        ISubtractionOperators<T,T,T>,
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
        public Complex(T newReal, T newImaginary)
        {
            this.real = newReal; 
            this.imaginary = newImaginary;

        }
        public Complex(T newReal)
        {
            this.real = newReal;
            this.imaginary = T.Zero;

        }

        

        public static Complex<T> E => new Complex<T>(T.E);

        public static Complex<T> Pi => new Complex<T>(T.Pi);

        public static Complex<T> Tau => new Complex<T>(T.Tau);

        public static Complex<T> One => new Complex<T>(T.One);
        public static Complex<T> ImaginaryOne => new Complex<T>(T.Zero,T.One);
        

        public static int Radix => 2;

        public static Complex<T> Zero => new Complex<T>(T.Zero);
        public static Complex<T> AdditiveIdentity => Zero;

        public static Complex<T> MultiplicativeIdentity => One;

        public static Complex<T> Abs(Complex<T> value)
        {
            return new Complex<T>(T.Sqrt(T.Pow(value.real, T.One+ T.One) + T.Pow(value.imaginary, T.One+ T.One)));
        }

        public static Complex<T> Cbrt(Complex<T> x)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> Hypot(Complex<T> x, Complex<T> y)
        {
            throw new NotImplementedException();
        }

        public static bool IsCanonical(Complex<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsComplexNumber(Complex<T> value)
        {
            return true;
        }

        public static bool IsEvenInteger(Complex<T> value)
        {
            return false;
        }

        public static bool IsFinite(Complex<T> value)
        {
            return T.IsFinite(value.real)&&T.IsFinite(value.imaginary);
        }

        public static bool IsImaginaryNumber(Complex<T> value)
        {
            return value.real.Equals(T.Zero);
        }

        public static bool IsInfinity(Complex<T> value)
        {
            return !IsFinite(value);
        }

        public static bool IsInteger(Complex<T> value)
        {
            return false;
        }

        public static bool IsNaN(Complex<T> value)
        {
            return T.IsNaN(value.real)&&T.IsNaN(value.imaginary);
        }

        public static bool IsNegative(Complex<T> value)
        {
            return T.IsNegative(value.real);
        }

        public static bool IsNegativeInfinity(Complex<T> value)
        {
            return T.IsNegativeInfinity(value.real) && T.IsNegativeInfinity(value.imaginary);

        }

        public static bool IsNormal(Complex<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsOddInteger(Complex<T> value)
        {
            return false;
        }

        public static bool IsPositive(Complex<T> value)
        {
            return T.IsPositive(value.real);
        }

        public static bool IsPositiveInfinity(Complex<T> value)
        {
            return T.IsInfinity(value.real) && T.IsInfinity(value.imaginary);
        }

        public static bool IsRealNumber(Complex<T> value)
        {
            return value.imaginary.Equals(T.Zero);
        }

        public static bool IsSubnormal(Complex<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(Complex<T> value)
        {
            return value.Equals(Zero);
        }

        public static Complex<T> MaxMagnitude(Complex<T> x, Complex<T> y)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> MaxMagnitudeNumber(Complex<T> x, Complex<T> y)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> MinMagnitude(Complex<T> x, Complex<T> y)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> MinMagnitudeNumber(Complex<T> x, Complex<T> y)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> Pow(Complex<T> x, Complex<T> y)
        {
            Complex<T> lnx = Log(x);
            return Exp(lnx * y);
        }

        public static Complex<T> RootN(Complex<T> x, int n)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> Sqrt(Complex<T> x)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Complex<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Complex<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Complex<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Complex<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Complex<T>>.TryConvertFromChecked<TOther>(TOther value, out Complex<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Complex<T>>.TryConvertFromSaturating<TOther>(TOther value, out Complex<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Complex<T>>.TryConvertFromTruncating<TOther>(TOther value, out Complex<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Complex<T>>.TryConvertToChecked<TOther>(Complex<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Complex<T>>.TryConvertToSaturating<TOther>(Complex<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Complex<T>>.TryConvertToTruncating<TOther>(Complex<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Complex<T>? other)
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
                return "("+imaginary.ToString(format, formatProvider) + ")i";
            }
            
            if (T.IsNegative(imaginary))
            {
                return real.ToString(format, formatProvider) + " - (" + T.Abs(imaginary).ToString(format, formatProvider)+")i";
            }
            else
            {
                return real.ToString(format, formatProvider) + " + (" + imaginary.ToString(format, formatProvider)+")i";
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
                return "("+imaginary.ToString() + ")i";
            }

            if (T.IsNegative(imaginary))
            {
                return real.ToString() + " - (" + T.Abs(imaginary).ToString() + ")i";
            }
            else
            {
                return real.ToString() + " + (" + imaginary.ToString() + ")i";
            }
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static Complex<T> Acos(Complex<T> x)
        {
            return -ImaginaryOne * Log(x + Sqrt(x * x - One));
        }

        public static Complex<T> AcosPi(Complex<T> x)
        {
            return Acos(x) / Pi;
        }

        public static Complex<T> Asin(Complex<T> x)
        {
            return -ImaginaryOne * Log(ImaginaryOne*x + Sqrt(x * x - One));
        }

        public static Complex<T> AsinPi(Complex<T> x)
        {
            return Asin(x) / Pi;

        }

        public static Complex<T> Atan(Complex<T> x)
        {
            return Log((One + x) / (One - x))/new Complex<T>(T.One+T.One)*ImaginaryOne;
        }

        public static Complex<T> AtanPi(Complex<T> x)
        {
            return Atan(x) / Pi;

        }

        public static Complex<T> Cos(Complex<T> x)
        {
            return (Exp(ImaginaryOne * x) - Exp(-ImaginaryOne * x)) / (T.One+T.One);
        }

        public static Complex<T> CosPi(Complex<T> x)
        {
            return Cos(x) / Pi;
        }

        public static Complex<T> Sin(Complex<T> x)
        {
            return (Exp(ImaginaryOne * x) - Exp(-ImaginaryOne * x))/(ImaginaryOne+ImaginaryOne);
        }

        public static (Complex<T> Sin, Complex<T> Cos) SinCos(Complex<T> x)
        {
            return (Sin(x), Cos(x));

        }

        public static (Complex<T> SinPi, Complex<T> CosPi) SinCosPi(Complex<T> x)
        {
            return (SinPi(x), CosPi(x));
        }

        public static Complex<T> SinPi(Complex<T> x)
        {
            return Sin(x) / Pi;
        }

        public static Complex<T> Tan(Complex<T> x)
        {
            return Sin(x)/Cos(x);
        }

        public static Complex<T> TanPi(Complex<T> x)
        {
            return Sin(x) / Cos(x) / Pi;
        }

        public static Complex<T> Acosh(Complex<T> x)
        {
            return Log(x + Sqrt(x * x - One));
        }

        public static Complex<T> Asinh(Complex<T> x)
        {
            return Log(x + Sqrt(x * x + One));
        }

        public static Complex<T> Atanh(Complex<T> x)
        {
            return Log((One+x)/(One-x))/(T.One + T.One);
        }

        public static Complex<T> Cosh(Complex<T> x)
        {
            return (Exp(x) + Exp(-x)) / (T.One + T.One);
        }

        public static Complex<T> Sinh(Complex<T> x)
        {
            return (Exp(x) - Exp(-x)) / (T.One + T.One);

        }

        public static Complex<T> Tanh(Complex<T> x)
        {
            return Sinh(x) / Cosh(x);
        }

        public static Complex<T> operator +(Complex<T> value)
        {
            return value;
        }

        public static Complex<T> operator +(Complex<T> left, Complex<T> right)
        {
            return new Complex<T>(left.real+right.real,left.imaginary+right.imaginary);   
        }

        public static Complex<T> operator -(Complex<T> value)
        {
            return new Complex<T>(-value.real, -value.imaginary);
        }

        public static Complex<T> operator -(Complex<T> left, Complex<T> right)
        {
            return left + -right;
        }

        public static Complex<T> operator ++(Complex<T> value)
        {
            return value + Complex<T>.One;
        }

        public static Complex<T> operator --(Complex<T> value)
        {
            return value - Complex<T>.One;

        }

        public static Complex<T> operator *(Complex<T> left, Complex<T> right)
        {
            return new Complex<T>(left.real * right.real - left.imaginary * right.imaginary, left.real * right.imaginary + left.imaginary * right.real);
        }
        public Complex<T> Conjugate()
        {
            return new Complex<T>(real, -imaginary);
        }
        public T Magnitude()
        {
            return T.Sqrt(real * real + imaginary*imaginary);
        }
        public T Argument()
        {
            if (T.IsPositive(real))
            {
                return T.Atan(imaginary / real);
            }
            else if(T.IsNegative(real) && !T.IsNegative(imaginary))
            {
                return T.Atan(imaginary / real)+T.Pi;
            }
            else if(T.IsNegative(real) && T.IsNegative(imaginary))
            {
                return T.Atan(imaginary / real) - T.Pi;
            }
            else if(real==T.Zero && T.IsPositive(imaginary))
            {
                return T.Pi / (T.One + T.One);
            }
            else if (real == T.Zero && T.IsNegative(imaginary))
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
            if (T.IsPositive(real))
            {
                return T.AtanPi(imaginary / real);
            }
            else if (T.IsNegative(real) && !T.IsNegative(imaginary))
            {
                return T.AtanPi(imaginary / real) + T.One;
            }
            else if (T.IsNegative(real) && T.IsNegative(imaginary))
            {
                return T.AtanPi(imaginary / real) - T.One;
            }
            else if (real == T.Zero && T.IsPositive(imaginary))
            {
                return T.One / (T.One + T.One);
            }
            else if (real == T.Zero && T.IsNegative(imaginary))
            {
                return -T.One / (T.One + T.One);
            }
            else
            {
                return T.One / T.Zero;
            }
        }
        public static Complex<T> Log(Complex<T> x)
        {
            return new Complex<T>(T.Log(x.Magnitude()), x.Argument());
        }

        public static Complex<T> Log(Complex<T> x, Complex<T> newBase)
        {
            return Complex<T>.Log(x)/Complex<T>.Log(newBase);
        }

        public static Complex<T> Log10(Complex<T> x)
        {
            return Complex<T>.Log(x) / T.Log((T.One + T.One)*((T.One + T.One)*(T.One + T.One)+T.One));
        }

        public static Complex<T> Log2(Complex<T> x)
        {
            return Complex<T>.Log(x) / T.Log(T.One + T.One);
        }

        public static Complex<T> Exp(Complex<T> x)
        {
            return new Complex<T>(T.Exp(x.real) + T.Cos(x.imaginary), T.Sin(x.imaginary));
        }

        public static Complex<T> Exp10(Complex<T> x)
        {
            return Pow(new Complex<T>((T.One + T.One) * ((T.One + T.One) * (T.One + T.One) + T.One)),x);
        }

        public static Complex<T> Exp2(Complex<T> x)
        {
            return Pow(new Complex<T>((T.One + T.One) * ((T.One + T.One) * (T.One + T.One) + T.One)), x);
        }

        public static Complex<T> operator /(Complex<T> left, Complex<T> right)
        {
            return left * right.Conjugate() / (right.real * right.real + right.imaginary * right.imaginary);
        }

        public static Complex<T> operator %(Complex<T> left, Complex<T> right)
        {
            
            Complex<T> q = left / right;
            Complex<T> rq = new Complex<T>(T.Zero+Math.Round(q.real.ToDouble(CultureInfo.InvariantCulture)),T.Zero+ Math.Round(q.imaginary.ToDouble(CultureInfo.InvariantCulture)));
            return left - rq * right;

        }

        public static bool operator ==(Complex<T>? left, Complex<T>? right)
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

        public static bool operator !=(Complex<T>? left, Complex<T>? right)
        {
            if (left == null) return false;

            return !left.Equals(right);
        }

        public static Complex<T> operator /(Complex<T> left, T right)
        {
            return new Complex<T>(left.real/right,left.imaginary/right);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Complex<T>);
        }
    }
}
