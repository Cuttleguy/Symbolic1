using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Vector<T> : IAdditionOperators<Vector<T>,Vector<T>,Vector<T>>,IEnumerable<T>,IMultiplyOperators<Vector<T>,T,Vector<T>>,IMultiplyOperators<Vector<T>,Matrix<T>,Vector<T>>,ISubtractionOperators<Vector<T>,Vector<T>,Vector<T>>,IUnaryNegationOperators<Vector<T>,Vector<T>>,IFormattable
        where T : IMultiplyOperators<T,T,T>,
        IAdditionOperators<T,T,T>,
        IUnaryNegationOperators<T,T>,
        IFormattable,
        INumberBase<T>,
        IConvertible,
        IAdditionOperators<T,double,T>
    {
        public T[] elements;
        public Vector(params T[] elements)
        {
            this.elements = elements;
        }
        /*public Vector(params T[] elements)
        {
            this.elements = elements;
        }*/
        public override string ToString()
        {
            string toReturn = string.Empty;
            foreach (T element in elements)
            {
                toReturn += element.ToString();
                toReturn += Environment.NewLine;
            }
            return toReturn;
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            string toReturn = string.Empty;
            foreach(T element in elements)
            {
                toReturn += element.ToString(format, formatProvider);
                toReturn += Environment.NewLine;
            }
            return toReturn;
        }

        public static Vector<T> operator +(Vector<T> left, Vector<T> right)
        {
            if(left.elements.Length != right.elements.Length)
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
            return new Vector<T>(newValues);

        }

        /*public static Vector<T> operator -(Vector<T> value)
        {
            return -T
        }
*/      public int Length => elements.Length;
        public T this[int index]
        { get { return elements[index]; }
          set { elements[index] = value; }
        }
        public static Vector<T> operator *(T left, Vector<T> right)
        {
            
            T[] newValues = new T[right.elements.Length];
            for(int i = 0;i < right.elements.Length;i++)
            {
                T element= right.elements[i];
                newValues[i] = left * element;
            }    
            return new Vector<T>(newValues);
        }

        public static Vector<T> operator *(Vector<T> left, T right)
        {
            return right * left;
        }
        public Vector(int size)
        {
            elements = new T[size];
            for (int i = 0; i < size; i++)
            {
                elements[i] = T.Zero;
                
            }
        }


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
            for(int i = 0; i < right.elements.Length; i++)
            {
                T rightElement = right.elements[i];
                T leftElement = left.elements[i];
                result += leftElement * rightElement;
            }    
            return result;

        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /*public static Vector<T> Cross(Vector<T> left, Vector<T> right)
{
   throw new NotImplementedException();
}*/
        public static Vector<T> operator -(Vector<T> value)
        {
            return -T.One * value;
        }

        public static Vector<T> operator -(Vector<T> left, Vector<T> right)
        {
            return left + -right;
        }

        public static Vector<T> operator *(Vector<T> left, Matrix<T> right)
        {
            return right * left;
        }
    }
}
