using System;
/// <summary>
/// New generic list Queue of type T
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    /// <summary>
    /// New function for check type
    /// </summary>
    /// <returns>Type of T</returns>
    Node head = new Node;
    Node tail = new Node;
    int count;
    public class Node
    {
        Node next = null;
        int value = null;
        public Node(Node value)
        {
            Value = value;
        }

        public string Value
        {
            set;
        }


    }
}

