using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static int NumberOfKeys(Dictionary<string, string> myDict)
        {
            int nbKeys = 0;
            foreach (var key in myDict)
            {
                nbKeys++;
            }
            return nbKeys;
        }
    }

