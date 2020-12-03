using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        var unique = new HashSet<int>(myList);
        int sum = unique.Sum();
        return sum;
    }
}
