using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class Matrix
    {
        public Matrix Inverse()
        {
            if (this.Row != this.Column)
            {
                throw new ArgumentException("This matrix is not square matrix");
            }

            Matrix Mat = new Matrix(_array);
            Matrix InvMat = new Matrix(Mat.Row,"eye");
            
            for(int i = 0; i < Mat.Row; i++)
            {
                double max = Math.Abs(Mat[i, i]);
                int pivot = i;
                for(int j = i + 1; j < this.Row; j++)
                {
                    if (max < Mat[j, i])
                    {
                        max = Mat[j, i];
                        pivot = j;
                    }
                }
                if (pivot != i)
                {
                    for(int k = 0;  k < this.Column; k++)
                    {
                        double tmp = Mat[pivot, k];
                        Mat[pivot, k] = Mat[i,k];
                        Mat[i, k] = tmp;
                        tmp = InvMat[pivot, k];
                        InvMat[pivot, k] = InvMat[i,k];
                        InvMat[i,k] = tmp;

                    }
                }

                double buf = 1 / Mat[i,i];
                for(int  j = 0; j < Mat.Row; j++)
                {
                    Mat[i,j] *= buf;
                    InvMat[i,j] *= buf;
                }

                for(int j= 0; j < Mat.Row; j++)
                {
                    if (i != j)
                    {
                        buf = Mat[j,i];
                        for(int k= 0; k < Mat.Column; k++)
                        {
                            Mat[j, k] -= Mat[i,k]*buf;
                            InvMat[j, k] -= InvMat[i,k]*buf;
                        }
                    }
                }
            }
            return InvMat;
        }
    }
}
