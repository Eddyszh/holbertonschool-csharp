using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>
    /// Test Str class
    /// </summary>
    public class StrTests
    {
        /// <summary>
        /// Test to check the unique char
        /// </summary>
        [TestCase("hholl")]
        [TestCase("sscchhool")]
        [TestCase("bbeetyy")]
        [TestCase("heelloo")]
        public void UniqueChar_ReturnIndex(string s)
        {
            //Expected ouutput
            int output = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i + 1).Contains(s[i].ToString()) == false &&
                    s.Substring(0, i).Contains(s[i].ToString()) == false)
                {
                    output = i;
                    break;
                }
            }

            //Get test index
            var index = Str.UniqueChar(s);
            Assert.That(index == output);
        }

        /// <summary>
        /// Test to check the unique char in a string with one char
        /// </summary>
        [TestCase("f")]
        [TestCase("g")]
        public void UniqueChar_WhenStringIsOneChar_ReturnIndex(string s)
        {
            //Get test index
            var index = Str.UniqueChar(s);
            Assert.That(index == 0);
        }

        /// <summary>
        /// Test to check the unique char in a string with many unique char
        /// </summary>
        [TestCase("example")]
        [TestCase("power")]
        [TestCase("group")]
        public void UniqueChar_WhenStringIsManyUniqueChar_ReturnIndex(string s)
        {
            //Expected ouutput
            int output = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i + 1).Contains(s[i].ToString()) == false &&
                    s.Substring(0, i).Contains(s[i].ToString()) == false)
                {
                    output = i;
                    break;
                }
            }
            //Get test index
            var index = Str.UniqueChar(s);
            Assert.That(index == output);
        }

        /// <summary>
        /// Test to check the unique char in a string with no unique char
        /// </summary>
        [TestCase("www")]
        [TestCase("gogo")]
        [TestCase("anna")]
        public void UniqueChar_WhenNoUniqueChar_ReturnIndex(string s)
        {
            //Get test index
            var index = Str.UniqueChar(s);
            Assert.That(index == -1);
        }

        /// <summary>
        /// Test to check the unique char in a string with two chars
        /// </summary>
        [TestCase("ff")]
        [TestCase("gg")]
        public void UniqueChar_WhenTwoNoUniqueChar_ReturnIndex(string s)
        {
            //Get test index
            var index = Str.UniqueChar(s);
            Assert.That(index == -1);
        }

        /// <summary>
        /// Test to check when null is passed
        /// </summary>
        [TestCase(null)]
        public void UniqueChar_WhenNull_ReturnIndex(string s)
        {
            //Get test index
            var index = Str.UniqueChar(s);
            Assert.That(index == -1);
        }
    }
}
