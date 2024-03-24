using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class RowVector
    {
        public static RowVector Hadamart(RowVector left, RowVector right)
        {
            if (left.Dim != right.Dim)
            {
                throw new ArgumentException("Vector dimention is different");
            }

            double[] array = new double[left.Dim];

            for (int i = 0; i < left.Dim; i++)
            {
                array[i] = left[i] * right[i];
            }

            return new RowVector(array);
        }
    }
}
