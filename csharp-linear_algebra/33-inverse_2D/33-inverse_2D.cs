﻿using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] error = new double[1, 1] { { -1 } };
        double[,] matrixInverse = new double[2, 2];

        if (matrix.GetLength(1) < 2)
        {
            return error;
        }

        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (determinant == 0)
        {
            return error;
        }
        matrixInverse[0, 0] = Math.Round(matrix[1, 1] / determinant, 2);
        matrixInverse[0, 1] = Math.Round(-matrix[0, 1] / determinant, 2);
        matrixInverse[1, 0] = Math.Round(-matrix[1, 0] / determinant, 2);
        matrixInverse[1, 1] = Math.Round(matrix[0, 0] / determinant, 2);

        return matrixInverse;
    }
}
