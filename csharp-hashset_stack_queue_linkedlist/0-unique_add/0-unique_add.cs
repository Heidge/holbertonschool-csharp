using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        HashSet<int> uniqueNb = new HashSet<int>(myList);

        for (int i = 0; i < myList.Count; i++)
        {
            uniqueNb.Add(myList[i]);
        }
        foreach (var item in uniqueNb)
        {
            sum += item;
        }
        return sum;
    }
}
