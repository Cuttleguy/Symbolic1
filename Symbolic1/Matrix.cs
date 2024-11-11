using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic1
{
    public class Matrix<T>:IAdditionOperators<Matrix<T>,Matrix<T>,Matrix<T>>,IMultiplyOperators<Matrix<T>,T,Matrix<T>>,IMultiplyOperators<Matrix<T>,Vector<T>,Vector<T>>,IMultiplyOperators<Matrix<T>,Matrix<T>,Matrix<T>>,IFormattable
        where T :
        IAdditionOperators<T, T, T>,
        IAdditionOperators<T,double,T>,
        IMultiplyOperators<T, T, T>,
        IFormattable,
        IUnaryNegationOperators<T,T>,
        INumberBase<T>,
        IConvertible
    {
        public Vector<T>[]? columns;
        public int height=0;
        public Matrix(int width, int height)
        {
            columns=new Vector<T>[width];
            for(int i = 0; i < width; i++)
            {
                columns[i]=new Vector<T>(height);
            }
            this.height = height;
        }
        public Matrix(Vector<T>[]? columns)
        {

            foreach(Vector<T> column in columns)
            {   
                if(height == 0)
                {
                    height=column.Length;
                }
                else if(height!=column.Length)
                {
                    throw new ArgumentException("Non Uniform Vectors");
                }
                
            }
            this.columns = columns;
        }
        public static Matrix<T> operator +(Matrix<T> left, Matrix<T> right)
        {
            Vector<T>[]? columns = new Vector<T>[left.width];
            if(left.width!=right.width||left.height!=right.height)
            {
                throw new ArgumentException("Can Only Add Matrices of Same Dimensions");
            }
            for (int i = 0; i < left.width; i++)
            {
                Vector<T> leftColumn = left[i];
                Vector<T> rightColumn = right[i];
                columns[i] = leftColumn + rightColumn;

            }
            return new Matrix<T>(columns);
        }

        public static Vector<T> operator *(Matrix<T> left, Vector<T> right)
        {
            Vector<T> result=new Vector<T>(left.width);
            if(left.width!=right.Length)
            {
                throw new ArgumentException("Mismatching Dimensions");
            }
            for (int i = 0; i < right.Length; i++)
            {
                result += right[i] * left[i];
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> left, Matrix<T> right)
        {
            if(left.width!=right.height)
            {
                throw new ArgumentException("Mismatrching Dimensions");
            }
            Matrix<T> result = new Matrix<T>(right.width,left.height);
            for (int i = 0; i < right.width; i++)
            {
                result[i] = left * right[i];
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> left, T right)
        {
            List<Vector<T>> vectors = new List<Vector<T>>();
            for (int i = 0; i < left.width; i++)
            {
                vectors[i] = left[i] * right;
            }
            return new Matrix<T>( vectors.ToArray() );
        }

        public static T Determinant(Matrix<T> matrix)
        {
            if(matrix.width!=matrix.height)
            {
                throw new ArgumentException("Nonsquare. How ammusing");
            }
            if(matrix.width==2)
            {
                return matrix[0][0] * matrix[1][1]-matrix[0][1]*matrix[1][0];
            }
            else
            {
                T result = T.Zero;
/*                Matrix<T> toReturn = new Matrix<T>(matrix.width,matrix.height);
*/              for (int i = 0; i < matrix.width; i++)
                {
                    List<Vector<T>> vectors = new List<Vector<T>>();
                    for (int j = 0; j < matrix.width; j++)
                    {
                        vectors.Add(new Vector<T>(matrix[j].Skip<T>(1).ToArray<T>()));

                    }
                    List<Vector<T>> newVectors = new List<Vector<T>>();
                    for (int j = 0; j < vectors.Count; j++)
                    {
                        if(j!=i)
                        {
                            newVectors.Add(vectors[j]);
                        }
                    }
                    Matrix<T> toDet = new Matrix<T>(newVectors.ToArray());

                    result += matrix[i][0] * Matrix<T>.Determinant(toDet);



                    
                }
                return result;
                
            }
        }
        public static Matrix<T> Invert(Matrix<T> matrix)
        {
            // Ensure the matrix is square
            if (Matrix<T>.Determinant(matrix)==T.Zero)
            {
                throw new ArgumentException("0 Det");
            }

            int n = matrix.width;

            // Step 1: Create an augmented matrix [matrix | I]
            Matrix<T> augmented = new Matrix<T>(2 * n, n);

            // Initialize the augmented matrix with the original matrix on the left
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmented[i][j] = matrix[i][j]; // Original matrix
                }

                // Identity matrix on the right side
                augmented[n + i][i] = T.One;
            }

            // Step 2: Perform Gaussian Elimination
            for (int i = 0; i < n; i++)
            {
                // Find the pivot
                if (augmented[i][i] == T.Zero)
                {
                    // Swap with a row below to find a non-zero pivot
                    bool swapped = false;
                    for (int k = i + 1; k < n; k++)
                    {
                        if (augmented[k][i] != T.Zero)
                        {
                            // Swap rows
                            Vector<T> temp = augmented[i];
                            augmented[i] = augmented[k];
                            augmented[k] = temp;
                            swapped = true;
                            break;
                        }
                    }
                    if (!swapped)
                    {
                        throw new ArgumentException("Matrix is singular and cannot be inverted.");
                    }
                }

                // Scale the row to make the pivot element equal to one
                T pivot = augmented[i][i];
                augmented[i] = augmented[i] * (T.One / pivot);

                // Eliminate other rows
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        T factor = augmented[j][i];
                        augmented[j] = augmented[j] - factor * augmented[i];
                    }
                }
            }

            // Step 3: Extract the inverse matrix from the augmented matrix
            Matrix<T> inverse = new Matrix<T>(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inverse[i][j] = augmented[n + i][j];
                }
            }

            return inverse;

        }
        public static Matrix<T> Transpose(Matrix<T> matrix)
        {
            List<Vector<T>> vectors=new List<Vector<T>>();
            for (int i = 0; i < matrix.height; i++)
            {
                List<T> Ts = new List<T>();
                for (int j = 0; j < matrix.width; j++)
                {
                    Ts.Add(matrix[j][i]);
                }
                vectors.Add(new Vector<T>(Ts.ToArray()));
            }
            return new Matrix<T>(vectors.ToArray());
        }
        public static T Contract(Matrix<T> matrix)
        {
            T toReturn = T.Zero;
            if(matrix.width!=matrix.height)
            {
                throw new ArgumentException("Not A Square!");
            }
            else
            {
                for (int i = 0; i < matrix.width; i++)
                {
                    toReturn += matrix[i][i];
                }
            }
            return toReturn;
        }
        /*public static Vector<T> Contract(Matrix<T> matrix,int index)
        {
            if(index != 0 && index != 1)
            {
                throw new ArgumentException("Index out of range for contraction of matrix");
            }
            Vector<T> toReturn = T.Zero;
            if (matrix.width != matrix.height)
            {
                throw new ArgumentException("Not A Square!");
            }
            else
            {
                for (int i = 0; i < matrix.width; i++)
                {
                    toReturn += matrix[i][i];
                }
            }
            return toReturn;
        }*/
        public string ToString()
        {
            string toReturn = string.Empty;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    T element = this[j][i];
                    toReturn += element.ToString() + " ";
                }
                toReturn += Environment.NewLine;
            }
            return toReturn;
        }
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            string toReturn = string.Empty;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    T element = this[j][i];
                    toReturn+= element.ToString(format, formatProvider)+" ";
                }
                toReturn += Environment.NewLine;
            }
            return toReturn;
        }

        int Length => columns.Length;
        public int width => Length;
        public Vector<T> this[int index]
        {
            get { return columns[index]; }
            set { columns[index] = value;  }
        }
    }
}
