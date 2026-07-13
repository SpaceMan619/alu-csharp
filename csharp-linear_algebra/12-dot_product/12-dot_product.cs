using System;

/// <summary>Provides vector calculations.</summary>
class VectorMath
{
    /// <summary>Returns the dot product of two equally sized vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null ||
            (vector1.Length != 2 && vector1.Length != 3) ||
            vector1.Length != vector2.Length)
            return -1;

        double result = 0;
        for (int i = 0; i < vector1.Length; i++)
            result += vector1[i] * vector2[i];
        return result;
    }
}
