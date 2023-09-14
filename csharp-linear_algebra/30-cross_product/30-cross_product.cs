using System;

    class VectorMath
    {
        public static double[] CrossProduct(double[] vector1, double[] vector2)
        {
            double[] result = new double[vector1.Length];

            for (int i = 0; i < vector1.Length; i++)
            result[i] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
            return result;
        }
    }
