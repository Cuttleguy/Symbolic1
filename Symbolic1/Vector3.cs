using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Vector3<T> : Vector<T>,IAdditionOperators<Vector3<T>, Vector3<T>, Vector3<T>>,ISubtractionOperators<Vector3<T>, Vector3<T>, Vector3<T>>,IMultiplyOperators<Vector3<T>,T, Vector3<T>>,IMultiplyOperators<Vector3<T>,Matrix<T>, Vector3<T>>,IDivisionOperators<Vector3<T>,T,Vector3<T>>
        ,IFormattable
        where T : IAdditionOperators<T, T, T>,
        IAdditionOperators<T,double,T>,
        IMultiplyOperators<T, T, T>,
        ISubtractionOperators<T, T, T>,
        IUnaryNegationOperators<T, T>,
        IFormattable,
        IRootFunctions<T>,
        INumberBase<T>,
        IConvertible
    {

        public T x => elements[0];
        public T y => elements[1];
        public T z => elements[2];

        public Vector3(T[] elements) : base(elements)
        {
            if (elements.Length != 3)
            {
                throw new ArgumentException();
            }
        }
        public T Norm()
        {
            return T.Sqrt(x * x + y * y + z * z);
        }
        public Vector3(T x, T y,T z) : base([x, y, z])
        {
            
        }
        public static Vector3<T> ihat = new Vector3<T>(T.One, T.Zero, T.Zero);
        public static Vector3<T> jhat = new Vector3<T>(T.Zero, T.One, T.Zero);
        public static Vector3<T> khat = new Vector3<T>(T.Zero, T.Zero, T.One);

        public static Vector3<T> Cross(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }
        public static Vector3<T> operator +(Vector3<T> left, Vector3<T> right)
        {
            if (left.elements.Length != right.elements.Length)
            {
                throw new ArgumentException("Trying to add two vectors of different sizes");
            }
            T[] newValues = new T[left.elements.Length];
            for (int i = 0; i < left.elements.Length; i++)
            {
                T leftElement = left.elements[i];
                T rightElement = right.elements[i];
                newValues[i] = leftElement + rightElement;

            }
            return new Vector3<T>(newValues);

        }

        /*public static Vector<T> operator -(Vector<T> value)
        {
            return -T
        }
        
*/      public int Length => elements.Length;
        /*public string ToString(string format, IFormatProvider provider)
        {
            return x.ToString(format, provider) + ", " + y.ToString(format, provider) + ", " + z.ToString(format, provider);
        }*/
        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }
        public static Vector3<T> operator *(T left, Vector3<T> right)
        {

            T[] newValues = new T[right.elements.Length];
            for (int i = 0; i < right.elements.Length; i++)
            {
                T element = right.elements[i];
                newValues[i] = left * element;
            }
            return new Vector3<T>(newValues);
        }

        public static Vector3<T> operator *(Vector3<T> left, T right)
        {
            return right * left;
        }
        /*public Vector3(int size)
        {
            elements = new T[size];
            for (int i = 0; i < size; i++)
            {
                elements[i] = T.Zero;

            }
        }*/


        /*public static Vector<T> operator *(Vector<T> left, Vector<T> right)
        {
            throw new NotImplementedException();
        }
*/
        public static T Dot(Vector<T> left, Vector<T> right)
        {
            if (left.elements.Length != right.elements.Length)
            {
                throw new ArgumentException("Trying to dot two vectors of different sizes");
            }
            T result = T.Zero;
            for (int i = 0; i < right.elements.Length; i++)
            {
                T rightElement = right.elements[i];
                T leftElement = left.elements[i];
                result += leftElement * rightElement;
            }
            return result;

        }

        /*public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }*/

        /*public static Vector<T> Cross(Vector<T> left, Vector<T> right)
{
   throw new NotImplementedException();
}*/
        public static Vector3<T> Round(Vector3<T> value,int digits)
        {
            return new Vector3<T>(T.Zero + Math.Round(value.x.ToDouble(CultureInfo.InvariantCulture), digits), T.Zero + Math.Round(value.y.ToDouble(CultureInfo.InvariantCulture), digits), T.Zero + Math.Round(value.z.ToDouble(CultureInfo.InvariantCulture), digits));
        }
        public static Vector3<T> operator -(Vector3<T> value)
        {
            return -T.One * value;
        }

        public static Vector3<T> operator -(Vector3<T> left, Vector3<T> right)
        {
            return left + -right;
        }

        public static Vector3<T> operator *(Vector3<T> left, Matrix<T> right)
        {
            return (Vector3<T>)(right * left);
        }

        public static Vector3<T> operator /(Vector3<T> left, T right)
        {
            return left * (T.One / right);
        }
        public static Vector3<T> Normalize(Vector3<T> vector)
        {
            return vector/vector.Norm();
        }
    }
}
