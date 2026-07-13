using System;

/// <summary>Provides matrix transformations.</summary>
public class MatrixMath
{
    /// <summary>Shears a 2x2 matrix in the x or y direction.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        direction = char.ToLowerInvariant(direction);
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 ||
            (direction != 'x' && direction != 'y'))
            return new double[,] { { -1 } };

        double[,] result = new double[2, 2];
        for (int column = 0; column < 2; column++)
        {
            if (direction == 'x')
            {
                result[0, column] = Math.Round(
                    matrix[0, column] + factor * matrix[1, column], 2);
                result[1, column] = Math.Round(matrix[1, column], 2);
            }
            else
            {
                result[0, column] = Math.Round(matrix[0, column], 2);
                result[1, column] = Math.Round(
                    factor * matrix[0, column] + matrix[1, column], 2);
            }
        }
        return result;
    }
}

