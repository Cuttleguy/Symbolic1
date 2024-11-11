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
    public class Quaternion<T> : IEquatable<Quaternion<T>>,INumberBase<Quaternion<T>>,
        IAdditionOperators<Quaternion<T>,Quaternion<T>,Quaternion<T>>,
        ISubtractionOperators<Quaternion<T>,Quaternion<T>,Quaternion<T>>,
        IMultiplyOperators<Quaternion<T>, Quaternion<T>, Quaternion<T>>,
        IDivisionOperators<Quaternion<T>,T, Quaternion<T>>,
        IDivisionOperators<Quaternion<T>, Quaternion<T>, Quaternion<T>>,
        IAdditionOperators<Quaternion<T>,Vector3<T>,Quaternion<T>>,
        IMultiplyOperators<Quaternion<T>, Vector3<T>,Quaternion<T>>


        where T : INumberBase<T>, IEquatable<T>,IAdditionOperators<T,T,T>,ISubtractionOperators<T,T,T>,IMultiplyOperators<T,T,T>,IDivisionOperators<T,T,T>,IUnaryNegationOperators<T,T>,
        IPowerFunctions<T>,
        IRootFunctions<T>,
        IAdditionOperators<T,double,T>,
        ITrigonometricFunctions<T>,
        IHyperbolicFunctions<T>,
        IExponentialFunctions<T>,
        IConvertible
        
    {
        public T real;
        public T imaginary;
        public T jmaginary;
        public T kmaginary;

        public static Quaternion<T> One => new Quaternion<T>(T.One);

        public static int Radix => throw new NotImplementedException();
        public static Quaternion<T> I => new Quaternion<T>(T.Zero, T.One);
        public static Quaternion<T> J => new Quaternion<T>(T.Zero, T.Zero,T.One);
        public static Quaternion<T> K => new Quaternion<T>(T.Zero, T.Zero,T.Zero, T.One);


        public static Quaternion<T> Zero => new Quaternion<T>(T.Zero);

        public static Quaternion<T> AdditiveIdentity => Zero;

        public static Quaternion<T> MultiplicativeIdentity => One;

        public Quaternion(T real, T imaginary, T jmaginary, T kmaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
            this.jmaginary = jmaginary;
            this.kmaginary = kmaginary;
        }
        public Quaternion(T real, T imaginary, T jmaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
            this.jmaginary = jmaginary;
            this.kmaginary = T.Zero;
        }
        public Quaternion(T real, T imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
            this.jmaginary = T.Zero;
            this.kmaginary = T.Zero;
        }
        public Quaternion(T real)
        {
            this.real = real;
            this.imaginary = T.Zero;
            this.jmaginary = T.Zero;
            this.kmaginary = T.Zero;
        }

        public bool Equals(Quaternion<T>? other)
        {
            if(other == null)
            {
                return false;
            }
            else
            {
                return this == other;
            }
        }
        public Quaternion(T scalar, Vector3<T> other)
        {
            real=scalar;
            imaginary = other.x;
            jmaginary=other.y;
            kmaginary=other.z;
        }

        public static Quaternion<T> Abs(Quaternion<T> value)
        {
            return new Quaternion<T>(T.Sqrt(value.real * value.real + value.imaginary * value.imaginary + value.jmaginary * value.jmaginary + value.kmaginary * value.kmaginary));
        }
        public static T Norm(Quaternion<T> quaternion)
        {
            return T.Sqrt(quaternion.real * quaternion.real + quaternion.imaginary * quaternion.imaginary + quaternion.jmaginary * quaternion.jmaginary + quaternion.kmaginary * quaternion.kmaginary);
        }

        public static bool IsCanonical(Quaternion<T> value)
        {
            return true;
        }

        public static bool IsComplexNumber(Quaternion<T> value)
        {
            return value.jmaginary == T.Zero && value.kmaginary == T.Zero;
        }

        public static bool IsEvenInteger(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsFinite(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsImaginaryNumber(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInfinity(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInteger(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNaN(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegative(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegativeInfinity(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNormal(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsOddInteger(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositive(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositiveInfinity(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsRealNumber(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsSubnormal(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(Quaternion<T> value)
        {
            return value == Zero;
        }

        public static Quaternion<T> MaxMagnitude(Quaternion<T> x, Quaternion<T> y)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> MaxMagnitudeNumber(Quaternion<T> x, Quaternion<T> y)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> MinMagnitude(Quaternion<T> x, Quaternion<T> y)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> MinMagnitudeNumber(Quaternion<T> x, Quaternion<T> y)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            string realstr;
            if (real == T.Zero)
            {
                realstr = string.Empty;

            }
            else
            {
                realstr = real.ToString(format, formatProvider);
            }
            string imagstr;
            if(imaginary==T.Zero)
            {
                imagstr = string.Empty;
            }
            else if(T.IsNegative(imaginary))
            {
                imagstr = " - " + T.Abs(imaginary).ToString(format, formatProvider)+"i";
            }
            else
            {
                imagstr= " + "+ imaginary.ToString(format, formatProvider)+"i";
            }
            string jmagstr;
            if (jmaginary == T.Zero)
            {
                jmagstr = string.Empty;
            }
            else if (T.IsNegative(jmaginary))
            {
                jmagstr = " - " + T.Abs(jmaginary).ToString(format, formatProvider)+"j";
            }
            else
            {
                jmagstr = " + " + jmaginary.ToString(format, formatProvider)+"j";
            }
            string kmagstr;
            if (kmaginary == T.Zero)
            {
                kmagstr = string.Empty;
            }
            else if (T.IsNegative(kmaginary))
            {
                kmagstr = " - " + T.Abs(kmaginary).ToString(format, formatProvider)+"k";
            }
            else
            {
                kmagstr = " + " + kmaginary.ToString(format, formatProvider)+"k";
            }
            return realstr + imagstr + jmagstr + kmagstr;
        }

        public static Quaternion<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Quaternion<T>>.TryConvertFromChecked<TOther>(TOther value, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Quaternion<T>>.TryConvertFromSaturating<TOther>(TOther value, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Quaternion<T>>.TryConvertFromTruncating<TOther>(TOther value, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Quaternion<T>>.TryConvertToChecked<TOther>(Quaternion<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Quaternion<T>>.TryConvertToSaturating<TOther>(Quaternion<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<Quaternion<T>>.TryConvertToTruncating<TOther>(Quaternion<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> operator +(Quaternion<T> left, Quaternion<T> right)
        {
            return new Quaternion<T>(left.real+right.real,left.imaginary+right.imaginary,left.jmaginary+right.jmaginary,left.kmaginary+right.kmaginary);
        }

        public static Quaternion<T> operator --(Quaternion<T> value)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> operator /(Quaternion<T> left, Quaternion<T> right)
        {
            return left * Quaternion<T>.Invert(right);
        }

        public static bool operator ==(Quaternion<T>? left, Quaternion<T>? right)
        {
            return left.real==right.real&&left.imaginary==right.imaginary&&left.jmaginary==right.jmaginary&&left.kmaginary==right.kmaginary;
        }

        public static bool operator !=(Quaternion<T>? left, Quaternion<T>? right)
        {
            return !(left == right);
        }

        public static Quaternion<T> operator ++(Quaternion<T> value)
        {
            return value + One;
        }

        public static Quaternion<T> operator *(Quaternion<T> left, Quaternion<T> right)
        {
            return new Quaternion<T>(
                left.real * right.real - left.imaginary * right.imaginary - left.jmaginary * right.jmaginary - left.kmaginary * right.kmaginary,
                left.real * right.imaginary + left.imaginary * right.real + left.jmaginary * right.kmaginary - left.kmaginary * right.jmaginary,
                left.real * right.jmaginary + left.jmaginary * right.real - left.imaginary * right.kmaginary + left.kmaginary * right.imaginary,
                left.real * right.kmaginary + left.kmaginary * right.real + left.imaginary * right.jmaginary - left.jmaginary * right.imaginary);
        }

        public static Quaternion<T> operator -(Quaternion<T> left, Quaternion<T> right)
        {
            return left + -right;
        }

        public static Quaternion<T> operator -(Quaternion<T> value)
        {
            return new Quaternion<T>(-value.real, -value.imaginary, -value.jmaginary, -value.kmaginary);
        }

        public static Quaternion<T> operator +(Quaternion<T> value)
        {
            return value;
        }

        public static Quaternion<T> operator /(Quaternion<T> left, T right)
        {
            return new Quaternion<T>(left.real/right,left.imaginary/right,left.jmaginary/right, left.kmaginary/right);
        }

        public static Quaternion<T> operator +(Quaternion<T> left, Vector3<T> right)
        {
            return left + new Quaternion<T>(T.Zero, right);
        }

        public static Quaternion<T> operator *(Quaternion<T> left, Vector3<T> right)
        {
            return left * new Quaternion<T>(T.Zero, right);
        }

        public static Quaternion<T> FromRotationAroundVector(T angle, Vector3<T> vector)
        {
            return new Quaternion<T>(T.Cos(angle / (T.Zero + 2)), T.Sin(angle / (T.Zero + 2)) * Vector3<T>.Normalize(vector));

        }
        public static Quaternion<T> FromRotationAroundVectorPi(T angle, Vector3<T> vector)
        {
            /*Console.WriteLine(angle);
            Console.WriteLine(angle / (T.Zero + 2));
            Console.WriteLine(T.CosPi(angle / (T.Zero + 2)));*/
            return new Quaternion<T>(T.CosPi(angle / (T.Zero + 2)), T.SinPi(angle / (T.Zero + 2)) * Vector3<T>.Normalize(vector));

        }
        public static Quaternion<T> FromEulerAngles(T yaw,T pitch,T roll)
        {
            Quaternion<T> qYaw = Quaternion<T>.FromRotationAroundVector(yaw, Vector3<T>.khat);
            Quaternion<T> qPitch = Quaternion<T>.FromRotationAroundVector(yaw, Vector3<T>.ihat);
            Quaternion<T> qRoll = Quaternion<T>.FromRotationAroundVector(yaw, Vector3<T>.jhat);
            return qYaw * qPitch * qRoll;


        }
        public static Quaternion<T> Normalize(Quaternion<T> quaternion)
        {
            return quaternion / Quaternion<T>.Norm(quaternion);
        }
        public static Quaternion<T> Conjugate(Quaternion<T> quaternion)
        {
            return new Quaternion<T>(quaternion.real,-quaternion.imaginary,-quaternion.jmaginary,-quaternion.kmaginary);
        }
        public static Quaternion<T> Invert(Quaternion<T> quaternion)
        {
            return Quaternion<T>.Conjugate(quaternion) / (Quaternion<T>.Norm(quaternion)*Quaternion<T>.Norm(quaternion));
        }
        public  Quaternion<T> Invert()
        {
            return Quaternion<T>.Invert(this);
        }
        public static Vector3<T> ExtractVector(Quaternion<T> quaternion)
        {
            return new Vector3<T>(quaternion.imaginary, quaternion.jmaginary, quaternion.kmaginary);
        }
        public Vector3<T> ExtractVector()
        {
            return Quaternion<T>.ExtractVector(this);
        }
    }
}
