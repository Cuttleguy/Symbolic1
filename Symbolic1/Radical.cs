/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Radical<T> :
        IMultiplyOperators<Radical<T>, Radical<T>, Radical<T>>,
        IDivisionOperators<Radical<T>, Radical<T>, Radical<T>>
    where T:
        IAdditionOperators<T,T,T>,
        ISubtractionOperators<T,T,T>,
        IMultiplyOperators<T,T,T>,
        IDivisionOperators<T,T,T>,
        IEquatable<T>,
        IPowerFunctions<T>,
        ITrigonometricFunctions<T>,
        IHyperbolicFunctions<T>,
        IModulusOperators<T,T,T>,
        ILogarithmicFunctions<T>,
        IExponentialFunctions<T>,
        IRootFunctions<T>



    {
        public Rational<T> coefficcient;
        public Algebraic<T> body;
        public int power;

        public static Radical<T> operator *(Radical<T> left, Radical<T> right)
        {
            throw new NotImplementedException();
        }

        public static Radical<T> operator /(Radical<T> left, Radical<T> right)
        {
            throw new NotImplementedException();
        }
    }
}
*/