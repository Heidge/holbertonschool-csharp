using System;
using System.Text;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// New class
    /// </summary>
    /// 

    public static class Str
    {
        public static int UniqueChar(string s)
        {
            char[] array = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                foreach (char c in array)
                {
                    if (c == array[i])
                        count += 1;
                }
                if (count == 1)
                    return i;
            }
            return -1;
        }
    }
}

