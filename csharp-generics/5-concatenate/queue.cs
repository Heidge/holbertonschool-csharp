﻿using System;

/// <summary>generic list Queue of type T</summary>
/// <typeparam name="T">generic type</typeparam>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count = 0;

    public class Node
    {
        /// <summary>class for object Node</summary>
        public T value = default(T);
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>method for check type of T</summary>
    /// <returns>type of T</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>new method for know number of node inside queue object</summary>
    /// <returns>number of node</returns>
    public int Count()
    { return count; }

    /// <summary>method for add a node to Queue object</summary>
    /// <param name="p">value of the node</param>
    public void Enqueue(T p)
    {
        Node n = new Node(p); 

        if (head == null)
        {
            head = n;
            tail = n;
        }
        else
        {
            tail.next = n;
            tail = n;
        }
        count++;
    }

    /// <summary>method for remove node in the queue</summary>
    /// <returns>default value if queue empty, else value removed</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
    }

    /// <summary>method for remove node in the queue</summary>
    /// <returns>default value if queue empty, else value removed</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    /// <summary>method for print the queue starting from the head</summary>
    /// <returns>default value if queue empty, else value removed</returns>
    public void Print()
    {
        if (head == null)
            Console.WriteLine("Queue is empty");
        else
        {
            Node n = head;
            for (; n != null; n = n.next)
            {
                Console.WriteLine(n.value);
            }
        } 
    }

    /// <summary>method for concatenate all values in the queue</summary>
    /// <returns>null if queue empty, else concatenation of all values</returns>
    public string Concatenate()
    {
        string concat = "";
        Node n = head;

        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else
        {
            for (; n != null; n = n.next)
            {
                if (CheckType() != typeof(string) || CheckType() != typeof(char))
                {
                    concat += n.value;
                }
                else
                {
                    Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
                    return null;
                }
            }
            return concat;
        }
    }
}
