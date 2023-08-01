using System;
using System.Collections.Generic;


    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {
            

            int nbArray = myMatrix.GetLength(0);
            int sizeArray = myMatrix.Length / nbArray;
            int[,] array2D = new int[nbArray, sizeArray];
            


            for (int i = 0; i < nbArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    array2D[i, j] = myMatrix[i, j] * myMatrix[i, j];
                }
            }
            return array2D;
        }
    }

