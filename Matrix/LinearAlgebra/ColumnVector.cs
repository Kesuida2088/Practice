using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class  ColumnVector
    {
        private int _dim;
        private double[] _values;

        public ColumnVector(int dimention)
        {
            _dim = dimention;
            _values = new double[_dim];
        }
        public ColumnVector(double[] values)
        {
            _dim = values.Length;
            _values = values;
        }

        public int Dim
        {
            get { return _dim; }
        }

        public double this[int index]
        {
            get { return _values[index]; }
        }
    }
}
