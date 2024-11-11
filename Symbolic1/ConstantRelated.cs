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
    public class ConstantRelated<T>:
        INumberBase<ConstantRelated<T>>,
        IFloatingPointConstants<ConstantRelated<T>>
        
        where T:INumberBase<T>
    {
        public T constant;
        public ConstantRelated<T>? piValue;
        public ConstantRelated<T>? eValue;
        public ConstantRelated(T constant, ConstantRelated<T> piValue, ConstantRelated<T> eValue)
        {
            this.constant = constant;
            this.piValue = piValue;
            this.eValue = eValue;
        }
        public ConstantRelated(T constant)
        {
            this.constant = constant;
        }
        public static ConstantRelated<T> One => new ConstantRelated<T>(T.One);

        public static int Radix => T.Radix;

        public static ConstantRelated<T> Zero => new ConstantRelated<T>(T.Zero);

        public static ConstantRelated<T> AdditiveIdentity => Zero;
        public static ConstantRelated<T> MultiplicativeIdentity => One;

        public static ConstantRelated<T> E => new ConstantRelated<T>(T.Zero,Zero,One);

        public static ConstantRelated<T> Pi => new ConstantRelated<T>(T.Zero, One, Zero);

        public static ConstantRelated<T> Tau => new ConstantRelated<T>(T.Zero,One+One,Zero);

        public static ConstantRelated<T> Abs(ConstantRelated<T> value)
        {
            if(value.eValue==null)
            {
                if(value.piValue!=null)
                {
                    return new ConstantRelated<T>(T.Abs(value.constant), Abs(value.piValue), null);
                }
                else
                {
                    return new ConstantRelated<T>(T.Abs(value.constant));
                }
            }
            if(value.piValue==null)
            {
                return new ConstantRelated<T>(T.Abs(value.))
            }
        }


        public static bool IsCanonical(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsComplexNumber(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsEvenInteger(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsFinite(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsImaginaryNumber(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInfinity(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInteger(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNaN(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegative(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegativeInfinity(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNormal(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsOddInteger(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositive(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositiveInfinity(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsRealNumber(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsSubnormal(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> MaxMagnitude(ConstantRelated<T> x, ConstantRelated<T> y)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> MaxMagnitudeNumber(ConstantRelated<T> x, ConstantRelated<T> y)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> MinMagnitude(ConstantRelated<T> x, ConstantRelated<T> y)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> MinMagnitudeNumber(ConstantRelated<T> x, ConstantRelated<T> y)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out ConstantRelated<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out ConstantRelated<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out ConstantRelated<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out ConstantRelated<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ConstantRelated<T>>.TryConvertFromChecked<TOther>(TOther value, out ConstantRelated<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ConstantRelated<T>>.TryConvertFromSaturating<TOther>(TOther value, out ConstantRelated<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ConstantRelated<T>>.TryConvertFromTruncating<TOther>(TOther value, out ConstantRelated<T> result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ConstantRelated<T>>.TryConvertToChecked<TOther>(ConstantRelated<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ConstantRelated<T>>.TryConvertToSaturating<TOther>(ConstantRelated<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        static bool INumberBase<ConstantRelated<T>>.TryConvertToTruncating<TOther>(ConstantRelated<T> value, out TOther result)
        {
            throw new NotImplementedException();
        }

        public bool Equals(ConstantRelated<T>? other)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> operator +(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> operator +(ConstantRelated<T> left, ConstantRelated<T> right)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> operator -(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> operator -(ConstantRelated<T> left, ConstantRelated<T> right)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> operator ++(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> operator --(ConstantRelated<T> value)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> operator *(ConstantRelated<T> left, ConstantRelated<T> right)
        {
            throw new NotImplementedException();
        }

        public static ConstantRelated<T> operator /(ConstantRelated<T> left, ConstantRelated<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(ConstantRelated<T>? left, ConstantRelated<T>? right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(ConstantRelated<T>? left, ConstantRelated<T>? right)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ConstantRelated<T>);
        }
    }
}
*/