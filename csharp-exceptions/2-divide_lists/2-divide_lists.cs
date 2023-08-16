using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> myList = new List<int>();
        int i = 0;
        int newValue = 0;

        for (i = 0; i < listLength; i++)
        {
            try
            {
                newValue = list1[i] / list2[i];
                myList.Add(newValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                myList.Add(0); ;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return myList;
    }
}
