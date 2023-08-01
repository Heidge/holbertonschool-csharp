using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var dictSorted = myDict.OrderBy(x => x.Key);

        foreach (var kvp in dictSorted)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

