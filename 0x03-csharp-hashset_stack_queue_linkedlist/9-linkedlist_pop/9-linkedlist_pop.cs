using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int value;
        if (myLList.Count > 0) value = myLList.First.Value;
        else return 0;
        myLList.RemoveFirst();
        return value;
    }
}
