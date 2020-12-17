using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>
    /// Test Str class
    /// </summary>
    public class StrTests
    {
        /// <summary>
        /// Test to check if the string is palindrome
        /// </summary>
        [TestCase("Opera")]
        [TestCase("level")]
        [TestCase("dad")]
        [TestCase("civiC")]
        public void IsPalindrome_ReturnsTrue(string s)
        {
            //Test palindrome
            bool isPalindrome = Str.IsPalindrome(s);
            Assert.That(isPalindrome == true);
        }

        /// <summary>
        /// Test to check if the string is palindrome whit special characters
        /// </summary>
        [TestCase("My gym")]
        [TestCase("Red rum, sir, is murder")]
        [TestCase("No lemon, no melon")]
        [TestCase("Was it a cat I saw")]
        public void IsPalindrome_WithSpecialCharacters_ReturnsTrue(string s)
        {
            //Test palindrome
            bool isPalindrome = Str.IsPalindrome(s);
            Assert.That(isPalindrome == true);
        }

        /// <summary>
        /// Test when string is not a palindrome
        /// </summary>
        [TestCase("rice")]
        [TestCase("Mouse")]
        [TestCase("Animal")]
        [TestCase("Love")]
        public void IsPalindrome_WithSpecialCharacters_ReturnsTrue(string s)
        {
            //Test palindrome
            bool isPalindrome = Str.IsPalindrome(s);
            Assert.That(isPalindrome == false);
        }

        /// <summary>
        /// Test with empty string
        /// </summary>
        [Test]
        public void IsPalindrome_WhenStringIsEmpty_ReturnsTrue()
        {
            //Empty string
            var s = string.Empty;
            //Test palindrome
            bool isPalindrome = Str.IsPalindrome(s);
            Assert.That(isPalindrome == true);
        }
    }
}
