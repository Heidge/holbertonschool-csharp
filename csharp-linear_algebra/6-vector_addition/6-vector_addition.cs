﻿using System;

/// <summary>
/// New class for vector calculation
/// </summary>
    class VectorMath
    {
        /// <summary>
        /// Method for add two vectors
        /// </summary>
        /// <param name="vector1">vector one</param>
        /// <param name="vector2">vector two</param>
        /// <returns>sum of these two vectors</returns>
        public static double[] Add(double[] vector1, double[] vector2)
        {

            int vector1Length = vector1.Length;
            int vector2Length = vector2.Length;
            double[] result = new double[vector1Length];
            double[] error = new double[1] {-1};
            if (vector1Length < 2 || vector1Length > 3 || vector2Length < 2 || vector2Length > 3 || vector1Length != vector2Length)
            {
                return error;
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
