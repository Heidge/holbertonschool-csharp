using System;

public static class Array
{
    public static int elementAt(int[] array, int index)
    {
        int arrayLength = array.Length;
        if (index >= 0 && index < arrayLength)
        {
            return (array[index]);
            
        }
        else
        {
           Console.WriteLine("Index out of range");
            return (-1);
        }
    }
}



