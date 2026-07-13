using System;

/// <summary>Provides vector calculations.</summary>
class VectorMath
{
    /// <summary>Returns the magnitude of a two- or three-dimensional vector.</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return -1;

        double sum = 0;
        foreach (double value in vector)
            sum += value * value;

        return Math.Round(Math.Sqrt(sum), 2);
    }
}
