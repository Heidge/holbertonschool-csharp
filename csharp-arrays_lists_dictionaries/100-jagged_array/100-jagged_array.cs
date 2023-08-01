﻿using System;
using System.Collections.Generic;

public static class Array
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[] { 0, 1, 2, 3 };
        jaggedArray[1] = new int[] { 0, 1, 2, 3, 4, 5, 6 };
        jaggedArray[2] = new int[] { 0, 1 };


        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write("{0} ", jaggedArray[i][j]);
            }
            Console.WriteLine();
        } 
    }
}