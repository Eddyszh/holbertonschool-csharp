using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
            if (i < 99) Console.Write("{0:00}, ", i);
            else Console.Write("{0}\n", i);
    }
}
