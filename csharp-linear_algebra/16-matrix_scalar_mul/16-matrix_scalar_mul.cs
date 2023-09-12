using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        double[,] error = new double[1, 1] {{ -1 }};

        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return error;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }
}
