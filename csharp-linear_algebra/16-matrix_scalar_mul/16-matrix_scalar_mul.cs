using System;

/// <summary>Provides matrix calculations.</summary>
public class MatrixMath
{
    /// <summary>Multiplies a 2x2 or 3x3 matrix by a scalar.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1) ||
            (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3))
            return new double[,] { { -1 } };

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];
        for (int row = 0; row < size; row++)
            for (int column = 0; column < size; column++)
                result[row, column] = Math.Round(matrix[row, column] * scalar, 2);
        return result;
    }
}

