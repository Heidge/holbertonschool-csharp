using System;
using System.Text;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// New class
    /// </summary>
    /// 

    public static class StringExtension
    {
        public static string RemovePunctuations(this string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
    public class Str
    {


        public static bool IsPalindrome(string s)
        {
            if (s == null || s.Length == 0)
            {
                return true;
            }
            else
            {
                string s_lower = s.ToLower();
                string new_s = s_lower.RemovePunctuations();
                string reverse = "";
                for (int i = new_s.Length - 1; i >= 0; i--)
                {
                    reverse += new_s[i];
                }
                if (new_s == reverse)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

