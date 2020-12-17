using NUnit.Framework;
using System.Linq;
using System;
using System.IO;

namespace MyMath.Tests
{
    /// <summary>
    /// Class for test the Matrix class
    /// </summary>
    public class MatrixTests
    {
        //private field matrix
        private int[,] matrix;

        /// <summary>
        /// Initializes a new matrix
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.matrix = new int[,] {
                { 0, 1, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };
        }

        /// <summary>
        /// Test for non zero integers
        /// </summary>
        [Test]
        public void Divide_ByNonZeroIntegers(
            [Values(12, 54, 56, -32, 87, 97, -78)] int div
        )
        {
            //Creates expected matrix
            int[,] newMatrix = new int[4, 4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[i, j] / div;
                }
            }

            //Test array
            var output = Matrix.Divide(this.matrix, div);
            //Test conditional
            bool areEqual = true;

            for (int i = 0; i < GetLength(0); i++)
            {
                for (int j = 0; j < GetLength(1); j++)
                {
                    if (matrix[i, j] != newMatrix[i, j])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            Assert.That(areEqual, Is.True);
        }

        /// <summary>
        /// Test divided by zero and returns null
        /// </summary>
        [TestCase(0)]
        public void Divide_ByZero_ReturnsNull(int num)
        {
            //Test array
            var newMatrix = Matrix.Divide(this.matrix, num);

            Assert.That(newMatrix == null);
        }

        /// <summary>
        /// Test divided by zero and prints
        /// </summary>
        [TestCase(0)]
        public void Divide_ByZero_Prints(int num)
        {
            StringWriter output = new StringWriter();
            Console.SetOut(output);

            //Test array
            var newMatrix = Matrix.Divide(this.matrix, num);

            Assert.That(output.ToString() == "Num cannot be 0\n");
        }

        /// <summary>
        /// Test divided by null and returns null
        /// </summary>
        [Test]
        public void Divide_MatrixNull(int num)
        {
            var newMatrix = Matrix.Divide(null, 9);

            Assert.That(newMatrix == null);
        }
    }
}
