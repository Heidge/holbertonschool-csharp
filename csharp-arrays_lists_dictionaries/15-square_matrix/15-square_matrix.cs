using System;
using System.Collections.Generic;


    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {
            int size = Convert.ToInt32(Math.Sqrt(myMatrix.Length));
            int[,] array2D = new int[size, size];
            
            for (int i = 0; i < Math.Sqrt(myMatrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(myMatrix.Length); j++)
                {
                    array2D[i, j] = myMatrix[i, j] * myMatrix[i, j];
                }
            }
            return array2D;
        }
    }

