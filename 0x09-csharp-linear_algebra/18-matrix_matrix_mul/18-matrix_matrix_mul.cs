using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// multiplies two matrices and returns the resulting matrix
    /// </summary>
    /// <return>
    /// the result or if the matrices cannot be multiplied, return a matrix containing -1
    /// </return>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] newMatrix = new double[matrix2.GetLength(0), matrix2.GetLength(1)];
        double num;

        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    num = 0;
                    for (int k = 0; k < newMatrix.GetLength(0); k++)
                    {
                        num += matrix1[i, k] * matrix2[k, j];
                    }
                    newMatrix[i, j] = Math.Round(num, 2);
                }
            }
            return newMatrix;
        }
        return new double[,] {{-1}};
    }
}
