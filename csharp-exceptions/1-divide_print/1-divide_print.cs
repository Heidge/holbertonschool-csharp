﻿using System;
using System.Collections.Generic;

class Int
{
    public static void divide(int a, int b)
    {
        int c = 0;
        try
        {
            c = a / b;
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {c}");
        }
    }
}
