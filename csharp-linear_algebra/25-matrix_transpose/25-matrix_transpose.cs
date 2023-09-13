using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];
        double[,] error = new double[,];

        if (matrix.Length == 0)
        {
            return error;
        }
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] += matrix[j, i];
            }
        }
        return result;
    }
}
