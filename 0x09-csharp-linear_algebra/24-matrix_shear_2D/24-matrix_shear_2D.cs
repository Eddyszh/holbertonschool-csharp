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
        double[,] newMatrix = new double[2, 2];
        double[,] shear = new double[,] { { 1, 0 }, { 0, 1 } };
        double num;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            if (direction == 'x')
                shear[1, 0] = factor;
            else if (direction == 'y')
                shear[0, 1] = factor;
            else
                return new double[,] {{-1}};

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    num = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        num += matrix[i, k] * shear[k, j];
                    }
                    newMatrix[i, j] = Math.Round(num, 2);
                }
            }
            return newMatrix;
        }
        return new double[,] {{-1}};
    }
}
