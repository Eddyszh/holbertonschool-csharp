using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;
        while (node != null)
        {
            if (node.Value > n) return myLList.AddBefore(node, n);
            node = node.Next;
        }
        return myLList.AddLast(n);
    }
}
