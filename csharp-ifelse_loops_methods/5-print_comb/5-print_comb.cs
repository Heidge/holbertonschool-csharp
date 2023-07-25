using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            for (i = 0; i <= 99; i++)
            {
                if (i < 99)
                {
                    if (k < 10 && j < 10)
                    {
                        Console.Write($"{k}{j}, ");
            
                    }
                    else
                    {
                        Console.Write($"{j}, ");
                    }
                    j++;
                }
                else
                {
                    Console.WriteLine($"{i}");
                }


            }
        }
    }
}
