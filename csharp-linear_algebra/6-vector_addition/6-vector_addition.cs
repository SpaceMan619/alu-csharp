using System;

/// <summary>Provides vector calculations.</summary>
public class VectorMath
{
    /// <summary>Adds two vectors of the same supported size.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null ||
            (vector1.Length != 2 && vector1.Length != 3) ||
            vector1.Length != vector2.Length)
            return new double[] { -1 };

        double[] result = new double[vector1.Length];
        for (int i = 0; i < result.Length; i++)
            result[i] = Math.Round(vector1[i] + vector2[i], 2);
        return result;
    }
}

