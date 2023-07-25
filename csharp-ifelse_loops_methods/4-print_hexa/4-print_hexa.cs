using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 98; i++)
            {
                Console.WriteLine($"{i} = 0x{i:X}");
            }
        }
    }
}
