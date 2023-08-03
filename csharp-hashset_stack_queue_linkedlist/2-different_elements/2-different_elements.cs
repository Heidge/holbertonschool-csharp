using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = GetDifference(list1, list2);
        List<int> newList2 = GetDifference(list2, list1);

        foreach (var item in newList2)
        {
            newList.Add(item);
        }

        List<int> GetDifference(List<int> list3, List<int> list4)
        {
            List<int> difference = new List<int>();

            foreach (int element in list3)
            {
                if (!list4.Contains(element))
                {
                    difference.Add(element);
                }
            }

            return difference;
        }
        newList.Sort();
        return newList;
    }
}
