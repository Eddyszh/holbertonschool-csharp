using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// rotates a square 2D matrix by a given angle in radians and returns the resulting matrix
    /// </summary>
    /// <return>
    /// the result or If the matrix is of an invalid size, return a matrix containing -1
    /// </return>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] temp = new double[,] { {Math.Cos(angle), Math.Sin(angle)}, {Math.Sin(angle) * -1, Math.Cos(angle)} };
        double[,] newMatrix = new double[2, 2];

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        newMatrix[i, j] = Math.Round(newMatrix[i, j] + matrix[i, k] * temp[k, j], 2);
                    }
                }
            }
            return newMatrix;
        }
        return new double[,] {{-1}};
    }
}
