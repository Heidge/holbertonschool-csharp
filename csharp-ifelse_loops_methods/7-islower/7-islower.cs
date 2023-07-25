using System;

namespace _7_islower
{
    class Character
    {
        public static bool IsLower(char c)
        {
            char letter;
            for (letter = 'a'; letter <= 'z'; letter++)
            {
                if (c == letter)
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
