using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace Sample1
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[,] array1 = new double[,]{ { 1, 1,-1},{ -2, 0, 1},{ 0,2,1} , { 4, 5, 3 } };
            double[,] array2 = new double[,]{ { 1, 2 ,3},{ 4, 5, 6 } };

            double[,] P = new double[,] { { 23634878.5219 }, { 20292688.2557 }, { 24032055.0372 }, { 24383229.2740 }, { 22170992.8178 } };
            Matrix Range = new Matrix(P);

            double[,] satpos = new double[,]{{-13897607.6294,-10930188.6233,19676689.6804},{-17800899.1998, 15689920.8120, 11943543.3888},
                { -1510958.2282, 26280096.7818, -3117646.1949},{-12210758.2517, 20413597.0201, -11649499.5474}, { -170032.6981, 17261822.6784, 20555984.4061} };

            double[,] sol = new double[4,1];

            Matrix SatPos = new Matrix(satpos);
            Matrix Rov = new Matrix(sol);

            var Cmn = new Program();

            Matrix ANS = Cmn.PointPos(SatPos, Rov, Range);

        }

        public Matrix PointPos(Matrix SatPos, Matrix RoverPos, Matrix Range)
        {
            Matrix H = new Matrix(SatPos.Row, 4);
            double[,] dr = new double[SatPos.Row,1];

            // Create Design Matrix
            for (int loop = 0; loop < 10; loop++)
            {
                for (int i = 0; i < SatPos.Row; i++)
                {
                    double r = Math.Sqrt(Math.Pow((SatPos[i, 0] - RoverPos[0, 0]), 2) +
                        Math.Pow((SatPos[i, 1] - RoverPos[1, 0]), 2) + Math.Pow((SatPos[i, 2] - RoverPos[2, 0]), 2));
                    dr[i, 0] = Range[i, 0] - r;
                    for (int j = 0; j < 4; j++)
                    {

                        if (j == 3)
                        {
                            H[i, j] = 1.0;
                        }
                        else
                        {
                            H[i, j] = (RoverPos[j, 0] - SatPos[i, j]) / r;
                        }
                    }
                }

                Matrix DR = new Matrix(dr);
                Matrix DeltaPos = (H.Transpose() * H).Inverse() * H.Transpose() * DR;

                RoverPos += DeltaPos;
            }

            return RoverPos;
        }
    }
}