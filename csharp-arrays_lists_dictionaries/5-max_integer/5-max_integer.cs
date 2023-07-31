using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        else if (myList.Count <= 0)
        {
            return 0;
        }
        else
        {
            int maxNumber = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] > maxNumber)
                {
                    maxNumber = myList[i];
                }
            }
            return maxNumber;
        }
    }
}

