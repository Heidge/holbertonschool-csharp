﻿using System;

    class VectorMath
    {
        public static double Magnitude(double[] vector)
        {
            int vectorLength = vector.Length;
            double result = 0;
            if (vectorLength < 2)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < vectorLength; i++)
                {
                    result += Math.Pow(vector[i], 2);
                    
                }
                result = Math.Sqrt(result);
                result = Math.Round(result, 2);
                return result;
            }
        }
    }
