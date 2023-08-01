using System;
using System.Collections.Generic;

public static class Array
{
    static void Main(string[] args)
    {
        int[] array = new int[5];

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i == 2 && j == 2)
                {
                    Console.Write("1 ");
                }
                else if (j == array.Length - 1)
                {
                    Console.WriteLine($"{array[i]}");

                }
                else
                {
                    Console.Write($"{array[i]} ");
                }

            }

        }
    }
}