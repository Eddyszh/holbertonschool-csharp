using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// calculates the inverse of a 2D matrix and returns the resulting matrix
    /// </summary>
    /// <return>
    /// the result or if the matrix is not a 2D matrix or if the matrix is non-invertible, return [-1]
    /// </return>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};

        double temp = matrix[1, 1];
        double det = 0;

        matrix[1, 1] = matrix[0, 0];
        matrix[0, 0] = temp;
        matrix[0, 1] *= -1;
        matrix[1, 0] *= -1;
        det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        if (det != 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Math.Round(matrix[i, j] / det, 2);
            return matrix;
        }
        return new double[,] {{-1}};
    }
}
