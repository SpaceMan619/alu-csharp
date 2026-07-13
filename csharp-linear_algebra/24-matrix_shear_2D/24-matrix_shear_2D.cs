using System;

/// <summary>Provides matrix transformations.</summary>
class MatrixMath
{
    /// <summary>Shears a 2x2 matrix in the x or y direction.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 ||
            (direction != 'x' && direction != 'y'))
            return new double[,] { { -1 } };

        double[,] result = new double[2, 2];
        for (int row = 0; row < 2; row++)
        {
            if (direction == 'x')
            {
                result[row, 0] = Math.Round(
                    matrix[row, 0] + factor * matrix[row, 1], 2);
                result[row, 1] = Math.Round(matrix[row, 1], 2);
            }
            else
            {
                result[row, 0] = Math.Round(matrix[row, 0], 2);
                result[row, 1] = Math.Round(
                    factor * matrix[row, 0] + matrix[row, 1], 2);
            }
        }
        return result;
    }
}
