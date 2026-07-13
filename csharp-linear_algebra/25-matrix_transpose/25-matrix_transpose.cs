using System;

/// <summary>Provides matrix calculations.</summary>
public class MatrixMath
{
    /// <summary>Returns a matrix with its rows and columns exchanged.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix == null)
            return new double[0, 0];

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        double[,] result = new double[columns, rows];
        for (int row = 0; row < rows; row++)
            for (int column = 0; column < columns; column++)
                result[column, row] = matrix[row, column];
        return result;
    }
}

