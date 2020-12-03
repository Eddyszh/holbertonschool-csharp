using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count <= 0) return "None";
        var max = myList.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        return max;
    }
}
