﻿using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        double[,] error = new double[1,1] {{-1}};

        if (determinant == 0 || matrix.Length != 2)
        {
            return error;
        }

        double[,] matrixInverse = new double[2, 2];

        matrixInverse[0, 0] = matrix[1, 1] / determinant;
        matrixInverse[0, 1] = -matrix[0, 1] / determinant;
        matrixInverse[1, 0] = -matrix[1, 0] / determinant;
        matrixInverse[1, 1] = matrix[0, 0] / determinant;

        return matrixInverse;
    }
}