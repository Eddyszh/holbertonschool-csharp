using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// shears a square 2D matrix by a given shear factor and returns the resulting matrix
    /// </summary>
    /// <return>
    /// the result or if the matrix is of an invalid size, or if given an axis that is not x or y return a matrix containing -1
    /// </return>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            if (direction == 'x')
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    Math.Round(matrix[0, i] += factor, 2);
                return matrix;
            }
            if (direction == 'y')
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                    Math.Round(matrix[i, 0] += factor, 2);
                return matrix;
            }
            return new double[,] {{-1}};
        }
        return new double[,] {{-1}};
    }
}
