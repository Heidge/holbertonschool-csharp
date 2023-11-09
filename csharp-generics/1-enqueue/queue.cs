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
    /// 
    public Node head;
    public Node tail;
    int count = 0;

    public class Node
    {
        /// <summary>
        /// New class for object Node
        /// </summary>
        public T value = default(T);
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
        }
    }

    public void Enqueue(T p)
    {
        Node n = new Node(p); 
        if (head == null)
        {
            head = n;
        }
        else
        {
            tail = n;
        }
        count++;
    }

    public int Count()
    { return count; }





}

