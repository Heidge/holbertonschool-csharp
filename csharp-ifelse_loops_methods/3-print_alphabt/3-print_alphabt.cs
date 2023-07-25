using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            for (letter = 'a'; letter <= 'z'; letter++)
            {
                if (letter != 'q' && letter != 'e')
                {
                    Console.Write(letter);
                }
            }
        }
    }
}
