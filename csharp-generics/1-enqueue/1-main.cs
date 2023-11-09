using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<float> myQ = new Queue<float>();

        myQ.Enqueue(9.72f);
        Console.WriteLine("Number of nodes in queue: " + myQ.Count());
    }
}