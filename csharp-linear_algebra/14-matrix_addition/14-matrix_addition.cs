using System;

/// <summary>Provides matrix calculations.</summary>
class MatrixMath
{
    /// <summary>Adds two equally sized 2x2 or 3x3 matrices.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (!IsSupported(matrix1) || !IsSupported(matrix2) ||
            matrix1.GetLength(0) != matrix2.GetLength(0) ||
            matrix1.GetLength(1) != matrix2.GetLength(1))
            return new double[,] { { -1 } };

        int size = matrix1.GetLength(0);
        double[,] result = new double[size, size];
        for (int row = 0; row < size; row++)
            for (int column = 0; column < size; column++)
                result[row, column] = matrix1[row, column] + matrix2[row, column];
        return result;
    }

    // Checks whether a matrix is square and has a supported size.
    private static bool IsSupported(double[,] matrix)
    {
        return matrix != null && matrix.GetLength(0) == matrix.GetLength(1) &&
            (matrix.GetLength(0) == 2 || matrix.GetLength(0) == 3);
    }
}
