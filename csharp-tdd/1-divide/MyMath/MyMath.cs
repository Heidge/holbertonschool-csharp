using System;

namespace MyMath
{
    /// <summary>
    /// New class
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// new method
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] new_matrix = new int[rows, cols];
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        new_matrix[i, j] = matrix[i, j] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return new_matrix;

        }
    }
}
