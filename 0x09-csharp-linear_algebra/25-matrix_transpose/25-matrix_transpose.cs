using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// transpose a matrix and return the resulting matrix
    /// </summary>
    /// <return>
    /// the result or if the matrix is empty, return an empty matrix
    /// </return>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] newMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
        if (matrix != null || matrix.Length != 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[j, i] = matrix[i, j];
                }
            }
            return newMatrix;
        }
        return new double[,] {};
    }
}
