using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {

        if (index <= 0)
        {
            LinkedListNode<int> nodeToRemove = myLList.First;
            myLList.Remove(nodeToRemove);
        }
        else if (index > myLList.Count)
        {
            myLList.Clear();
        }
        else
        {
            LinkedListNode<int> nodeToRemove = myLList.First;
            for (int i = 0; i < index; i++)
            {
                nodeToRemove = nodeToRemove.Next;
            }
            myLList.Remove(nodeToRemove);
        }
    }
}

