using System;

/// <summary>Provides matrix transformations.</summary>
class MatrixMath
{
    /// <summary>Rotates each vector in a 2x2 matrix by an angle in radians.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double cosine = Math.Cos(angle);
        double sine = Math.Sin(angle);
        double[,] result = new double[2, 2];

        for (int row = 0; row < 2; row++)
        {
            result[row, 0] = Math.Round(
                matrix[row, 0] * cosine - matrix[row, 1] * sine, 2);
            result[row, 1] = Math.Round(
                matrix[row, 0] * sine + matrix[row, 1] * cosine, 2);
        }
        return result;
    }
}
