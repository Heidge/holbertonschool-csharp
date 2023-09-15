using System;

/// <summary>
/// New class for vector calculation
/// </summary>
    class VectorMath
    {
        /// <summary>
        /// New method for calcul Dot product of two vectors
        /// </summary>
        /// <param name="vector1">vector one</param>
        /// <param name="vector2">vector two</param>
        /// <returns>Dot product of these two vectors</returns>
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            int vector1Length = vector1.Length;
            int vector2Length = vector2.Length;
            double[] newArray = new double[vector1Length];
            double result = 0;
            if (vector1Length < 2 || vector1Length > 3 || vector2Length < 2 || vector2Length > 3 || vector1Length != vector2Length)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < vector1Length; i++)
                {
                    newArray[i] = vector1[i] * vector2[i];
                }
                for (int i = 0; i < newArray.Length; i++)
                {
                    result += newArray[i];
                }
                return result;
            }
        }
    }
