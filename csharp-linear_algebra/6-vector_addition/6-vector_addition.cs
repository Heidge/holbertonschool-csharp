using System;

    class VectorMath
    {
        public static double[] Add(double[] vector1, double[] vector2)
        {

            int vector1Length = vector1.Length;
            int vector2Length = vector2.Length;
            double[] result = new double[];
            if (vector1Length < 2 || vector1Length > 3 || vector2Length < 2 || vector2Length > 3 || vector1Length != vector2Length)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < vector1Length; i++)
                {
                    result[i] = vector1[i] + vector2[i];
                }
                return result;
            }
        }
    }
