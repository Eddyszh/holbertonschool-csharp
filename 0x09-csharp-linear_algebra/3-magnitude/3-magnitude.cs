using System;

/// <summary>
/// Class to calculate vector maths
/// </summary>
class VectorMath
{
    /// <summary>
    /// calculates and returns the length of a given vector
    /// </summary>
    /// <return>
    /// the magnitude of the vector or -1 if is not a 2d nor 3d vector
    /// </return>
    public static double Magnitude(double[] vector)
    {
        //field to count the lenght of the vector
        double sum = 0;

        if (vector.Length < 2 || vector.Length > 3)
            return -1;
        foreach (int num in vector)
            sum += Math.Pow(num, 2);
        return Math.Round(Math.Sqrt(sum), 2);
    }
}
