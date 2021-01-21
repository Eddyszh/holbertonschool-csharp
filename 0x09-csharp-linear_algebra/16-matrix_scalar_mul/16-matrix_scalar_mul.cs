using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// multiplies a matrix and a scalar and returns the resulting matrix
    /// </summary>
    /// <return>
    /// the result or -1 if is not a 2d nor 3d matrix
    /// </return>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) > 1 && matrix.GetLength(1) < 4)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    newMatrix[i, j] = Math.Round(matrix[i, j] * scalar, 2);
            return newMatrix;
        }
        return new double[,] {{-1}};
    }
}
