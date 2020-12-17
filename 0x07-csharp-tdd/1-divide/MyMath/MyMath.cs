using System;

namespace MyMath
{
        /// <summary>
        /// Matrix class
        /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides a matrix
        /// </summary>
        /// <return>
        /// the new matrix or null if is divided by zero or if is null
        /// </return>
        public static int[,] Divide(int[,] matrix, int num)
        {
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                }
                return matrix;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            catch (System.NullReferenceException)
            {
                return null;
            }
        }
    }
}
