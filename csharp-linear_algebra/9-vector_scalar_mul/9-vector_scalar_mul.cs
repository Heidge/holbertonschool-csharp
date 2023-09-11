using System;

    class VectorMath
    {
        public static double[] Multiply(double[] vector, double scalar)
        {

            int vectorLength = vector1.Length;
            double[] result = new double[vector1Length];
            double[] error = new double[1] {-1};
            if (vectorLength < 2 || vectorLength > 3 )
            {
                return error;
            }
            else
            {
                for (int i = 0; i < vectorLength; i++)
                {
                    result[i] = vector[i] * scalar;
                }
                return result;
            }
        }
    }
