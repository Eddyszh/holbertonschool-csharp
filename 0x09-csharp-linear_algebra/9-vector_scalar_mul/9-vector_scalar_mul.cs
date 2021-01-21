using System;

/// <summary>
/// Class to calculate vector maths
/// </summary>
class VectorMath
{
    /// <summary>
    /// multiplies a vector and a scalar and returns the resulting vector
    /// </summary>
    /// <return>
    /// the result or -1 if is not a 2d nor 3d vector
    /// </return>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] newVector = new double[vector.Length];

        if (vector.Length < 2 || vector.Length > 3)
            return new double[] {-1};
        for (int i = 0; i < vector.Length; i++)
            newVector[i] = Math.Round(vector[i] * scalar, 2);
        return newVector;
    }
}
