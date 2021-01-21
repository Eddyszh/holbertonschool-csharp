using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// adds two matrices and returns the resulting matrix
    /// </summary>
    /// <return>
    /// the result or -1 if is not a 2d nor 3d matrix, or both matrix are not the same size
    /// </return>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] newMatrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if (matrix1.GetLength(1) > 1 && matrix1.GetLength(1) < 4)
        {
            if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.Length == matrix2.Length)
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                        newMatrix[i, j] = Math.Round(matrix1[i, j] + matrix2[i, j], 2);
                return newMatrix;
            }
        }
        return new double[,] {{-1}};
    }
}
