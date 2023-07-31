using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        int lengthMyList = myList.Count;
        List<bool> retVal = new List<bool>(new bool[lengthMyList]);

        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                retVal[i] = true;
            }
            else
            {
                retVal[i] = false;
            }
        }
        return retVal;
    }
}

