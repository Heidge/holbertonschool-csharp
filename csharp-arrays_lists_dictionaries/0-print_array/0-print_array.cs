using System;

public static class Array
{
    public static int[] CreatePrint(int size)
    {
        int index = 0;
        if (size > 0)
        {
            int[] Array = new int[size];
            foreach (int i in Array)
            {
                int arrayL = Array.Length;
                if (i == arrayL - 1)
                {
                    Console.Write($"{index}");
                }
                else
                {
                    Console.Write($"{index} ");
                }
                index++;
            }
            Console.WriteLine("");
            return Array;
        }
        else if (size == 0)
        {
            Console.WriteLine("");
            int[] Array = new int[size];
            return Array;
        }
        else
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

    }
}



