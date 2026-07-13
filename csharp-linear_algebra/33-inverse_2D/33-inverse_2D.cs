using System;

/// <summary>Provides matrix calculations.</summary>
public class MatrixMath
{
    /// <summary>Returns the inverse of an invertible 2x2 matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double determinant = matrix[0, 0] * matrix[1, 1] -
            matrix[0, 1] * matrix[1, 0];
        if (Math.Abs(determinant) < double.Epsilon)
            return new double[,] { { -1 } };

        return new double[,]
        {
            {
                Math.Round(matrix[1, 1] / determinant, 2),
                Math.Round(-matrix[0, 1] / determinant, 2)
            },
            {
                Math.Round(-matrix[1, 0] / determinant, 2),
                Math.Round(matrix[0, 0] / determinant, 2)
            }
        };
    }
}

