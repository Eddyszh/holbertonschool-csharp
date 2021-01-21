using System;

/// <summary>
/// Class to calculate vector maths
/// </summary>
class VectorMath
{
    /// <summary>
    /// adds two vectors and returns the resulting vector
    /// </summary>
    /// <return>
    /// the result or -1 if is not a 2d nor 3d vector
    /// </return>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] sum = new double[vector1.Length];

        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
            return new double[] {-1};
        for (int i = 0; i < vector1.Length; i++)
            sum[i] = Math.Round(vector1[i] + vector2[i], 2);
        return sum;
    }
}
