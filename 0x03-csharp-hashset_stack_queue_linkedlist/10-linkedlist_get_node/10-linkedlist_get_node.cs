using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int value = 0;
        foreach (int item in myLList)
        {
            if (value == n) return item;
            value++;
        }
        return 0;
    }
}
