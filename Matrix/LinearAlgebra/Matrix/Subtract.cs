using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class Matrix
    {
        public static Matrix operator -(Matrix left, Matrix right)
        {
            if ((left.Row != right.Row) || (left.Column != right.Column))
            {
                throw new ArgumentException("Input array size is invalid");
            }

            Matrix Mat = new Matrix(left.Row, left.Column);

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Column; j++)
                {
                    Mat[i, j] = left[i, j] - right[i, j];
                }
            }

            return Mat;
        }
    }
}
