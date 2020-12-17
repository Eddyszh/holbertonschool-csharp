using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Class for test the Operations class
    /// </summary>
    public class AddTests
    {
        /// <summary>
        /// Test valid arguments
        /// </summary>
        public void Add_TwoValues(
            [Values(0, 5, -45, -78, 65, 14, 132, 1321, 74574, 10010)] int a,
            [Values(4, 6, -7, -2, 74, 100, 35, 741, 98, 562)] int b)
        {
            //Add using the add method
            var sum = Operations.Add(a, b);
            Assert.That(sum == (a + b));
        }

        /// <summary>
        /// Test if integers are passed
        /// </summary>
        [Test]
        public void Add_MinAndMAxValue()
        {
            //Add using the add method
            var sum = Operations.Add(int.MinValue, int.MaxValue);
            Assert.That(sum == -1);
        }
    }
}
