using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class Matrix
    {
        public Matrix Join(Matrix right, string option)
        {
            if (option == "horizontal")
            {
                Matrix Mat = new Matrix(right.Row, this.Column + right.Column);
                return Mat;
            }
            else if(option == "vertical")
            {
                Matrix Mat = new Matrix(this.Row + right.Row, right.Column);
                return Mat;
            }
            else
            {
                throw new ArgumentException("Second input argument is invalid\n Set \"horizontal\" or \"vertical\"");
            }
           
        }
    }
}
