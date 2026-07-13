using System;

/// <summary>Provides vector calculations.</summary>
public class VectorMath
{
    /// <summary>Multiplies a supported vector by a scalar.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
            return new double[] { -1 };

        double[] result = new double[vector.Length];
        for (int i = 0; i < result.Length; i++)
            result[i] = Math.Round(vector[i] * scalar, 2);
        return result;
    }
}

