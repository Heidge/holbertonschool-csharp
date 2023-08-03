using System;
using System.Text;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLlist = new LinkedList<int>();
        if (size < 0)
        {
            return newLlist;
        }
        else
        {
            for (int i = 0; i < size; i++)
            {
                newLlist.AddLast(i);
                Console.WriteLine($"{i}");
            }
            return newLlist;
        }
    }
}
