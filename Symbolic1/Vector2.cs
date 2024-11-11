using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Vector2<T> :Vector<T>
        where T : IAdditionOperators<T,T,T>,
        IMultiplyOperators<T,T,T>,
        ISubtractionOperators<T,T,T>,
        IUnaryNegationOperators<T,T>,
        IFormattable,
        INumberBase<T>,
        IConvertible,
        IAdditionOperators<T,double,T>
    {
        public T x => elements[0];
        public T y => elements[1];

        public Vector2(T[] elements) : base(elements)
        {
            if(elements.Length!=2)
            {
                throw new ArgumentException();
            }
        }
        public Vector2(T x, T y) : base(new T[] {x,y})
        {

        }
        public static T Cross(Vector2<T> left, Vector2<T> right)
        {
            return left.elements[0] * right.elements[1]-left.elements[1]*right.elements[0];
        }
    }
}
