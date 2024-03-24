using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    internal partial class Matrix
    {
        private int _row;
        private int _column;
        private double[,] _array;

        public Matrix()
        {
            throw new Exception("Set row or colunmn size");
        }

        public Matrix(in double[,] array)
        {
            _row = array.GetLength(0);
            _column = array.GetLength(1);
            _array = array;
        }

        public Matrix(Matrix left, Matrix right, string option)
        {
            if ((option != "horizontal") && (option != "vertical"))
            {
                throw new ArgumentException("Third argument is invalid\n Set \"horizontal\" or \"vertical\"");
            }

            if(option == "horizontal")
            {
                if (left.Row != right.Row)
                {
                    throw new ArgumentException("Row size is invalid");
                }
                _row = right.Row;
                _column = right.Column + left.Column;
                _array = new double[_row, _column];

                for (int i = 0; i < _row; i++)
                {
                    for (int j = 0; j < _column; j++)
                    {
                        if (j < left.Column)
                        {
                            _array[i, j] = left[i, j];
                        }
                        else
                        {
                            _array[i, j] = right[i, j - left.Column];
                        }
                    }
                }
            }
            else if (option == "vertical")
            {
                if (left.Column != right.Column)
                {
                    throw new ArgumentException("Row size is invalid");
                }

                _row = right.Row + left.Row;
                _column = right.Column;
                _array = new double[_row, _column];

                for(int i = 0; i < _row; i++)
                {
                    for(int j = 0; j < _column; j++)
                    {
                        if (i < left.Row)
                        {
                            _array[i, j] = left[i, j];
                        }
                        else
                        {
                            _array[i, j] = right[i - left.Row, j];
                        }
                    }
                }
            }
        }

        public Matrix(int row, int column, string option = "default")
        {
            if ((row <= 0) || (column <= 0))
            {
                throw new ArgumentException("Input row or column value is invalid");
            }

            if ((option != "default") && (option != "eye"))
            {
                throw new Exception("Input \"eye\"");
            }

            _row = row;
            _column = column;
            _array = new double[row, column];

            if (option == "eye")
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (i == j)
                        {
                            _array[i, j] = 1.0;
                        }
                    }
                }
            }
        }

        public Matrix(int dim, string option = "default")
        {
            if (dim < 0)
            {
                throw new ArgumentException("First argument is invalid");
            }

            if ((option != "default") && (option != "eye"))
            {
                throw new ArgumentException("Second argument is invalid\n Set \"default\" or \"eye\"");
            }
            
            _row = dim;
            _column = dim;
            _array = new double[dim, dim];

            if (option == "eye")
            {
                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        if (i == j)
                        {
                            _array[i, j] = 1.0;
                        }
                    }
                }
            }
        }

        public int Row
        {
            get { return _row; }
        }

        public int Column
        {
            get { return _column; }
        }
        public double this[int i, int j]
        {
            get { return _array[i, j]; }
            set { _array[i, j] = value; }
        }
    }
}
