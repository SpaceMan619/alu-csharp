using System;

/// <summary>Provides vector calculations.</summary>
public class VectorMath
{
    /// <summary>Returns the cross product of two three-dimensional vectors.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null ||
            vector1.Length != 3 || vector2.Length != 3)
            return new double[] { -1 };

        return new double[]
        {
            Math.Round(vector1[1] * vector2[2] - vector1[2] * vector2[1], 2),
            Math.Round(vector1[2] * vector2[0] - vector1[0] * vector2[2], 2),
            Math.Round(vector1[0] * vector2[1] - vector1[1] * vector2[0], 2)
        };
    }
}

