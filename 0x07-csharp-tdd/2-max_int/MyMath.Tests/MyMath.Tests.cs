using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MyMath.Tests
{
    /// <summary>
    /// Class for test the Operations class
    /// </summary>
    public class MaxTests
    {
        /// <summary>
        /// Pass max int of a list
        /// </summary>
        [Test]
        public void Max_RetunsMaxInt(
            [Values(-56, -32, 0, 5, 48, 789)] int a,
            [Values(-68, -57, -7, 0, 78, 987)] int b
        )
        {
            //List for test
            List<int> nums = new List<int>() { 48, 35, a, 879, -46, 0, b, 87 };
            //Expected max value
            var max = nums.Max();
            //Max value
            var result = Operations.Max(nums);

            Assert.That(result == max);
        }

        /// <summary>
        /// Test in a list with one value
        /// </summary>
        [Test]
        public void Max_WhenListHasOneInt_ReturnsMaxInt()
        {
            //List for test
            List<int> nums = new List<int>() { 48 };
            //Expected max value
            var max = nums.Max();
            //Max value
            var result = Operations.Max(nums);

            Assert.That(result == max);
        }

        /// <summary>
        /// Test in a empty list
        /// </summary>
        [Test]
        public void Max_WhenEmptyList_ReturnsZero()
        {
            //List for test
            List<int> nums = new List<int>();
            //Max value
            var result = Operations.Max(nums);

            Assert.That(result == 0);
        }

        /// <summary>
        /// Test in a list with null value
        /// </summary>
        [Test]
        public void Max_NullValue_ReturnsZero()
        {
            //Max value
            var result = Operations.Max(null);

            Assert.That(result == 0);
        }
    }
}
