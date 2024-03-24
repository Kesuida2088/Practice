using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class Matrix
    {
        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left.Column != right.Row)
            {
                throw new ArgumentException("Input array size is invalid");
            }

            Matrix Mat = new Matrix(left.Row, right.Column);

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < right.Column; j++)
                {
                    for(int k = 0 ; k < left.Column; k++)
                    {
                        Mat[i, j] += left[i, k] * right[k, j];
                    }
                }
            }

            return Mat;
        }

        public static Matrix operator *(double scalar,in Matrix matrix)
        {
            Matrix Mat = new Matrix(matrix._array); // check

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Column; j++)
                {
                    Mat[i,j] = scalar * matrix[i,j];
                }
            }
            return Mat;
        }

        public static Matrix operator *(in Matrix matrix, double scalar)
        {
            return scalar* matrix;
        }
    }
}
