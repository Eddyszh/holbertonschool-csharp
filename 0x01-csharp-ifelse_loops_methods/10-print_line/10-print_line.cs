using System;

class Line
{
    public static void PrintLine(int length)
    {
        int i = 0;
        for (; i < length; i++)
            Console.Write('_');
        if (length <= 0 || i == length) Console.WriteLine();
    }
}
