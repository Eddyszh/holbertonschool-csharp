using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        myList.RemoveAt(index);
        return myList;
    }
}
