using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Radical<T> :
    IMultiplyOperators<Radical<T>, Radical<T>, Radical<T>>,
        IDivisionOperators<Radical<T>, Radical<T>, Radical<T>>,

    {
        public static Radical<T> operator *(Radical<T> left, Radical<T> right)
        {
            throw new NotImplementedException();
        }
    }
}
