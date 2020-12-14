using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;

        try
        {
            if (n <= myList.Count)
            {
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(myList[i]);
                }
            }
            else
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
        catch (System.ArgumentOutOfRangeException)
        {
            for (i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine(myList[i]);
                }
        }
        return i;
    }
}
