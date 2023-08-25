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
        public static int CamelCase(string s)
        {
            int count = 0;
            s.ToCharArray();
            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}


