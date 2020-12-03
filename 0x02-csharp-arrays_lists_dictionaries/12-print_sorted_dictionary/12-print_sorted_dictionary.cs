using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var keys = myDict.Keys.ToList();
        keys.Sort();
        foreach (var item in keys)
        {
            Console.WriteLine("{0}: {1}", item, myDict[item]);
        }
    }
}
