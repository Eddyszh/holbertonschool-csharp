using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int value;
        if (myLList.Count < n) return 0;
        else value = myLList.ElementAt(n);
        return value;
    }
}
