﻿using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array.Length == 0 || array == null)
        {
            Console.WriteLine("");
        }
        else
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i == 0)
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
