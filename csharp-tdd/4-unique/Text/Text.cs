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
            string one = "";
            string two = "";
            for (int i = 0; i < s.Length; i++)
            {
                one = s.Substring(i, 1);
                for (int j = 0; j < s.Length; j++)
                {
                    two = s.Substring(j, 1);
                    if ((one == two) && (i != j))
                        return j;
                }
            }
            return -1;
        }
    }
}

