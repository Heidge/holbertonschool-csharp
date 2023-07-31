using System;

namespace _0_print_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray;

            newArray = Array.CreatePrint(10);
            Console.WriteLine("Array Length: " + newArray.Length);
            Console.WriteLine("----------------");
            newArray = Array.CreatePrint(16);
            Console.WriteLine("Array Length: " + newArray.Length);
            Console.WriteLine("----------------");
            newArray = Array.CreatePrint(0);
            Console.WriteLine("Array Length: " + newArray.Length);
            Console.WriteLine("----------------");
            newArray = Array.CreatePrint(-10);
        }
    }
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size > 0)
            {
                int[] Array = new int[size];
                return Array;
            }
            else if (size == 0)
            {
                Console.WriteLine("");
                int[] Array = new int[size];
                return Array;
            }
            else
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }

        }
    }
}


