﻿using System;

namespace _11_print_diagonal
{
    class ExecutePrintDiagonal
    {
        static void Main(string[] args)
        {
            Line.PrintDiagonal(3);
            Line.PrintDiagonal(0);
            Line.PrintDiagonal(12);
            Line.PrintDiagonal(-98);
        }
    }

    class Line
    {
        public static void PrintDiagonal(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
        }
    }
}
