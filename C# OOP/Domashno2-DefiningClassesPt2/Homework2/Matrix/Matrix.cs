using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Common
{
    public class Matrix<T>
       where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T[,] matrix;
        private int rows, cols;

        public Matrix(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentException("Rows and columns in matrix cannot be negative!");
            }
            this.matrix = new T[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }

        // Access this matrix as a 2D array
        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Columns
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        // To add or subtract matrices they must have equal rows and columns
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new ArgumentException("Cannot add matrices with different number of rows or columns!");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Columns);
            for (int row = 0; row < matrix1.Rows; row++)
            {
                for (int col = 0; col < matrix1.Columns; col++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] + matrix2[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new ArgumentException("Cannot subtract matrices with different number of rows or columns!");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Columns);
            for (int row = 0; row < matrix1.Rows; row++)
            {
                for (int col = 0; col < matrix1.Columns; col++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] - matrix2[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
            {
                throw new ArgumentException("The number of columns of the 1st matrix must equal the number of rows of the 2nd matrix!");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Columns);
            for (int row = 0; row < matrix1.Rows; row++)
            {
                for (int col = 0; col < matrix2.Columns; col++)
                {
                    for (int i = 0; i < matrix1.Columns; i++)
                    {
                        result[row, col] += (dynamic)matrix1[row, i] * matrix2[i, col];
                    }
                }
            }
            return result;
        }

        public static Matrix<T> operator *(T multiplier, Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    matrix[row, col] = (dynamic)matrix[row, col] * multiplier;
                }
            }

            return matrix;
        }

        public static Boolean operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    result.Append(matrix[row, col].ToString().PadLeft(5) + " ");
                }
                result.AppendLine();
            }
            result.Length--;
            return result.ToString();
        }
    }
}