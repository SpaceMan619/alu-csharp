using System;

/// <summary>Provides matrix calculations.</summary>
public class MatrixMath
{
    /// <summary>Returns the determinant of a 2x2 or 3x3 matrix.</summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1) ||
            (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3))
            return -1;

        double result;
        if (matrix.GetLength(0) == 2)
        {
            result = matrix[0, 0] * matrix[1, 1] -
                matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            result =
                matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }
        return Math.Round(result, 2);
    }
}

