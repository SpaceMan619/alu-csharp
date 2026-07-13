using System;

/// <summary>Provides matrix calculations.</summary>
class MatrixMath
{
    /// <summary>Multiplies two compatible matrices.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null ||
            matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1 } };

        int rows = matrix1.GetLength(0);
        int shared = matrix1.GetLength(1);
        int columns = matrix2.GetLength(1);
        double[,] result = new double[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                double sum = 0;
                for (int i = 0; i < shared; i++)
                    sum += matrix1[row, i] * matrix2[i, column];
                result[row, column] = sum;
            }
        }
        return result;
    }
}
