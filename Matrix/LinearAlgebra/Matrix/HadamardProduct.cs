using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class Matrix
    {
        /// <summary>
        /// calcurate Hadamart Product
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Matrix HadamartProduct(Matrix right)
        {
            if ((_row != right.Row )|| (_column != right.Column))
            {
                throw new ArgumentException("Input array size is invalid");
            }
            
            Matrix Mat = new Matrix(this.Row, this.Column);

            for(int i = 0; i < this.Row; i++)
            {
                for(int j = 0; j < this.Column; j++)
                {
                    Mat[i,j] = this[i,j]*right[i,j];
                }
            }

            return Mat;
        }
    }
}
