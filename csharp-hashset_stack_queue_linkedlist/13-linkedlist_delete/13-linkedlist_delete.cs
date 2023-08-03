using System;
using System.Collections.Generic;

    class LList
    {
        public static void Delete(LinkedList<int> myLList, int index)
        {
            LinkedListNode<int> nodeToRemove = myLList.First;
            for (int i = 0; i < index; i++)
            {
                nodeToRemove = nodeToRemove.Next;
            }
            myLList.Remove(nodeToRemove);
        }
    }

