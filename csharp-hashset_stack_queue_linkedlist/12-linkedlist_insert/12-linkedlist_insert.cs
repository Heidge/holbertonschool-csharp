using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> currentNode = myLList.First;

        while (currentNode != null && currentNode.Value < n)
        {
            currentNode = currentNode.Next;
        }

        // Insérer le nouveau nœud avant le currentNode (si currentNode est null, cela signifie que le nombre doit être inséré à la fin)
        if (currentNode != null)
        {
            myLList.AddBefore(currentNode, n);
        }
        else
        {
            myLList.AddLast(n);
        }

        return currentNode;

    }
}

