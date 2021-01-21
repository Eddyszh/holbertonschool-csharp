using System;

/// <summary>
/// Class to calculate vector maths
/// </summary>
class VectorMath
{
    /// <summary>
    /// calculates dot product of either two 2D or two 3D vectors
    /// </summary>
    /// <return>
    /// the result or -1 if is not a 2d nor 3d vector, or both vectors are not the same size
    /// </return>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dot = 0;

        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
            return -1;
        for (int i = 0; i < vector1.Length; i++)
            dot += Math.Round(vector1[i] * vector2[i], 2);
        return dot;
    }
}
