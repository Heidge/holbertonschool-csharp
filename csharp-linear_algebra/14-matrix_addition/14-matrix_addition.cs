using System;

    class MatrixMath
    {
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            double[,] result = new double[,];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(0); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
    }
