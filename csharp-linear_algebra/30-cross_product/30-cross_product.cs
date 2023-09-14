using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {

        double[] result = new double[vector1.Length];
        double[] error = new double[1] {-1};

        if (vector1.Length != vector2.Length || vector1.Length < 3 || vector2.Length < 3)
        {
            return error;
        }

        result[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        result[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        result[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return result;
    }
}
