using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0) Console.WriteLine();
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("{0}", i);
            if (i < size - 1) Console.Write(" ");
        }
        Console.WriteLine();
        return arr;
    }
}
