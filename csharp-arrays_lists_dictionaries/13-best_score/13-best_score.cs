using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int bestScore = 0;
        string bestPeople = "";
        if (myList == null || myList.Count == 0)
        {
            bestPeople = "None";
        }
        else
        {
            foreach (var kvp in myList)
            {
                if (kvp.Value > bestScore)
                {
                    bestScore = kvp.Value;
                }
            }

            foreach (KeyValuePair<string, int> kvp in myList)
            {

                if (bestScore == kvp.Value)
                {
                    bestPeople = kvp.Key;
                    break;
                }
            }
        }
        return bestPeople;
    }
}

