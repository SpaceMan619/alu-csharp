using System;

/// <summary>Provides matrix transformations.</summary>
public class MatrixMath
{
    /// <summary>Rotates each vector in a 2x2 matrix by an angle in radians.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double cosine = Math.Cos(angle);
        double sine = Math.Sin(angle);
        double[,] result = new double[2, 2];

        for (int column = 0; column < 2; column++)
        {
            result[0, column] = Math.Round(
                cosine * matrix[0, column] - sine * matrix[1, column], 2);
            result[1, column] = Math.Round(
                sine * matrix[0, column] + cosine * matrix[1, column], 2);
        }
        return result;
    }
}

