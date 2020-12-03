using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] grid = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            grid[2, 2] = 1;
            Console.WriteLine("{0} {1} {2} {3} {4}", grid[i, 0], grid[i, 1], grid[i, 2], grid[i, 3], grid[i, 4]);
        }
    }
}
