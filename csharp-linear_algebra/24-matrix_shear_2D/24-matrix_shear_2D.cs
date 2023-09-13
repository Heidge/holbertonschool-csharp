using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        double[,] error = new double[1, 1] { { -1 } };

        if (matrix.GetLength(1) != matrix.GetLength(0))
        {
            return error;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (direction == "X")
                {
                    result[i, 0] += Math.Pow(j, factor);
                }
                else if (direction == "Y")
                {
                    result[0, j] += Math.Pow(i, factor);
                }
            }
        }
        return result;
    }
}
