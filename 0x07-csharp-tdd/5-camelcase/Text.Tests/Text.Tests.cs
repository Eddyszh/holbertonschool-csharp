using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        /// <summary>
        /// Test with one word
        /// </summary>
        [TestCase("holberton")]
        [TestCase("school")]
        [TestCase("betty")]
        public void CamelCase_WithOneWord_ReturnOne(string s)
        {
            //Get the test value
            int index = Str.CamelCase(s);
            Assert.That(index == 1);
        }

        /// <summary>
        /// Test with many words
        /// </summary>
        [TestCase("gitHubRepository", 3)]
        [TestCase("holbertonSchool", 2)]
        [TestCase("deleteThis", 2)]
        public void CamelCase_MultipleWords_ReturnCount(string s, int expected)
        {
            //Get the test value
            int index = Str.CamelCase(s);
            Assert.That(index == expected);
        }

        /// <summary>
        /// Test with acronyms
        /// </summary>
        [TestCase("UI", 2)]
        [TestCase("CSS", 3)]
        [TestCase("Html", 1)]
        public void CamelCase_AcronymsWords_ReturnCount(string s, int expected)
        {
            //Get the test value
            int index = Str.CamelCase(s);
            Assert.That(index == expected);
        }

        /// <summary>
        /// Test with no words
        /// </summary>
        [TestCase("")]
        public void CamelCase_NoWords_ReturnZero(string s)
        {
            //Get the test value
            int index = Str.CamelCase(s);
            Assert.That(index == 0);
        }

        /// <summary>
        /// Test with null passed
        /// </summary>
        [TestCase(null)]
        public void CamelCase_NullPassed_ReturnZero(string s)
        {
            //Get the test value
            int index = Str.CamelCase(s);
            Assert.That(index == 0);
        }
    }
}
