using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class RowVector
    {
        public static RowVector Transpose()
        {
            return new ColumnVector(_values);
        }
    }
}
