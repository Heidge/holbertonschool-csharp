using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int CountAStack = aStack.Count;

        Console.WriteLine($"Number of items: {CountAStack}");

        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }

        bool match = false;
        foreach (string index in aStack)
        {
            if (index == search)
            {
                match = true;
            }
        }
        Console.WriteLine($"Stack contains \"{search}\": {match}");

        if (aStack.Contains(search))
        {
            while (aStack.Pop() != search)
            {
                continue;
            }
        }

        aStack.Push(newItem);

        return aStack;
    }
}
