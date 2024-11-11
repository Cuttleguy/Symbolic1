using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Tensor<T> : IAdditionOperators<Tensor<T>, Tensor<T>, Tensor<T>>,IMultiplyOperators<Tensor<T>,T,Tensor<T>>,ISubtractionOperators<Tensor<T>,Tensor<T>,Tensor<T>>,IUnaryNegationOperators<Tensor<T>,Tensor<T>> where T : IAdditionOperators<T, T, T>, IMultiplyOperators<T, T, T>, ISubtractionOperators<T, T, T>, IUnaryNegationOperators<T, T>
    {
        public static Tensor<T> operator +(Tensor<T> left, Tensor<T> right)
        {
            throw new NotImplementedException();
        }

        public static Tensor<T> operator -(Tensor<T> value)
        {
            throw new NotImplementedException();
        }

        public static Tensor<T> operator -(Tensor<T> left, Tensor<T> right)
        {
            throw new NotImplementedException();
        }

        public static Tensor<T> operator *(Tensor<T> left, T right)
        {
            throw new NotImplementedException();
        }
    }
}
