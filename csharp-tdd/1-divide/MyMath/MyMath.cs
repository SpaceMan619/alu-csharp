using System;

namespace MyMath
{
    /// <summary>Provides matrix operations.</summary>
    public static class Matrix
    {
        /// <summary>Divides every matrix element by an integer.</summary>
        /// <param name="matrix">The matrix to divide.</param>
        /// <param name="num">The divisor.</param>
        /// <returns>A new divided matrix, or <c>null</c> for null input or a zero divisor.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            try
            {
                if (num == 0)
                {
                    throw new DivideByZeroException();
                }

                int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int column = 0; column < matrix.GetLength(1); column++)
                    {
                        result[row, column] = matrix[row, column] / num;
                    }
                }

                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
