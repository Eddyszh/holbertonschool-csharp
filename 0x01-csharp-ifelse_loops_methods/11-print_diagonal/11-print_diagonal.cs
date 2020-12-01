using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i > 0 && j <= i - 1) Console.Write(" ");
                    else Console.WriteLine('\\');
                }
            }
        }
        else Console.WriteLine();
    }
}
