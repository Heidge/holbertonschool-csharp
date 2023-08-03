using System;
using System.Collections.Generic;


    class MyQueue
    {
        public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
        {
            int CountAQueue = aQueue.Count;

        Console.WriteLine($"Number of items: {CountAQueue}");

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }

        bool match = false;
        foreach (string index in aQueue)
        {
            if (index == search)
            {
                match = true;
            }
        }
        Console.WriteLine($"Queue contains \"{search}\": {match}");

        if (aQueue.Contains(search))
        {
            while (aQueue.Dequeue() != search)
            {
                continue;
            }
        }

        aQueue.Enqueue(newItem);

        return aQueue;
        }
    }
