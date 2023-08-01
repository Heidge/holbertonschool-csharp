using System;
using System.Collections.Generic;


    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {
            int[,] array2D = new int[3, 3];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2D[i, j] = myMatrix[i, j] * myMatrix[i, j];
                }
            }
            return array2D;
        }
    }

