using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            int i = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{myList[i]}");
            }
            return i;
        }
        catch
        {
            return n;
        }
    }
}
