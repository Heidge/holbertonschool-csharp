using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 99; i++)
            {
                if (i < 10)
                {
                    Console.Write($"0{i}");
                }
                else
                {
                    Console.Write($"{i}");
                }
                if (i < 99)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
