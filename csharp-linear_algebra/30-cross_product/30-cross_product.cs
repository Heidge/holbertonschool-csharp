using System;

    VectorMath
    {
        public static double[] CrossProduct(double[] vector1, double[] vector2)
        {
            double[] result = new double[vector1.Length];
            result = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
            return result;
        }
    }
