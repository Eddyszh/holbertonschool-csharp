using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        var newList = new List<int>();
        var unique = new HashSet<int>(list1);
        unique.IntersectWith(list2);
        foreach (var item in unique)
            newList.Add(item);
        newList.Sort();
        return newList;
    }
}
