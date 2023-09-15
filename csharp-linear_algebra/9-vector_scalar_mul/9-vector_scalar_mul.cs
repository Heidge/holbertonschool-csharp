using System;

/// <summary>
/// New class for vector calculation
/// </summary>
    class VectorMath
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector">vector gift</param>
        /// <param name="scalar">scalar index</param>
        /// <returns>vector scale by scalar index</returns>
        public static double[] Multiply(double[] vector, double scalar)
        {
            int vectorLength = vector.Length;
            double[] result = new double[vectorLength];
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
