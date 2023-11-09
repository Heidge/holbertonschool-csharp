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
    Node head;
    Node tail;
    int count;
    public class Node
    {
        Node next = null;
        T value = null;
        public Node(Node value)
        {
            Value = value;
        }
    }

    public void Enqueue(T t)
    {
        Node n = new Node(t);
        n.Value = head;
        head = n;
    }

    public int Count()
    {
        return this.Count;
    }
}
