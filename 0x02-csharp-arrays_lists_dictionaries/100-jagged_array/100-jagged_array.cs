using System;

class Program
{
    static void Main(string[] args)
    {
        int row;
        int col = 3;
        int[][] jagged = new int[][]
        {
            new int[] { 0, 1, 2, 3 },
            new int[] { 0, 1, 2, 3, 4, 5, 6 },
            new int[] { 0, 1 }
        };
        for (int i = 0; i < col; i++)
        {
            row = jagged[i].Length;
            for (int j = 0; j < row; j++)
                Console.Write((j != row - 1) ? $"{j} " : $"{j}\n");
        }
    }
}
