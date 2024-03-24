using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class Matrix   
    {
        public Matrix Transpose()
        {
            Matrix Mat = new Matrix(this.Column, this.Row);

            for (int i = 0; i < Mat.Row; i++)
            {
                for (int j = 0; j < Mat.Column; j++)
                {
                    Mat[i, j] = this[j, i];
                }
            }

            return Mat;
        }
    }
}
