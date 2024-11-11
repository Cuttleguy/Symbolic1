/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Tensor4d<T> : IAdditionOperators<Tensor4d<T>, Tensor4d<T>, Tensor4d<T>>, IUnaryNegationOperators<Tensor3d<T>, Tensor3d<T>>, IMultiplyOperators<Tensor3d<T>, T, Tensor3d<T>>, ISubtractionOperators<Tensor3d<T>, Tensor3d<T>, Tensor3d<T>> where T : IAdditionOperators<T, T, T>, IMultiplyOperators<T, T, T>, IUnaryNegationOperators<T, T>, IFormattable, INumberBase<T>
    {
        public Matrix<T>[] slices;
        public int depth => slices.Length;
        public int width = 0;
        public int height = 0;
        public Tensor4d(Matrix<T>[] slices)
        {
            foreach (Matrix<T> slice in slices)
            {
                if (width == 0 && height == 0)
                {
                    width = slice.width;
                    height = slice.height;
                }
                else if (width != slice.width || height != slice.height)
                {
                    throw new ArgumentException("Non uniform Matrices");
                }
            }

        }
        public Tensor4d(int depth, int width, int height)
        {
            for (int i = 0; i < depth; i++)
            {
                slices[i] = new Matrix<T>(width, height);
            }
            this.width = width;
            this.height = height;
        }
        public Matrix<T> this[int index]
        {
            get { return slices[index]; }
            set { slices[index] = value; }
        }

        public static Tensor4d<T> operator +(Tensor4d<T> left, Tensor3d<T> right)
        {

            if (left.width != right.width || left.height != right.height || left.depth != right.depth)
            {
                throw new ArgumentException("Non consistent Dimensions of Tensor3ds");
            }
            else
            {
                Tensor3d<T> toReturn = new Tensor4d<T>(left.depth, left.width, left.height);
                for (int i = 0; i < left.depth; i++)
                {
                    toReturn[i] = left[i] + right[i];
                }
                return toReturn;
            }
        }

        public static Tensor4   d<T> operator -(Tensor3d<T> value)
        {
            return value * -T.One;
        }

        public static Tensor3d<T> operator *(Tensor3d<T> left, T right)
        {
            Tensor3d<T> toReturn = new Tensor3d<T>(left.depth, left.width, left.height);
            for (int i = 0; i < left.depth; i++)
            {
                toReturn[i] = left[i] * right;
            }
            return toReturn;
        }

        public static Tensor3d<T> operator -(Tensor3d<T> left, Tensor3d<T> right)
        {
            return left + -right;
        }
        *//*public static Matrix<T> Contract(int index)
        {
            if(index >0 || index <2)
            {
                throw new ArgumentException("Out of range index to contract upon");
            }
            else
            {
                Matrix<T>
            }
        }*//*
    }
}
*/