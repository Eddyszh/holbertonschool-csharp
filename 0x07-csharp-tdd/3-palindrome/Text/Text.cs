using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Looks for a palindrome string
        /// </summary>
        /// <return>
        /// True if string is a palindrome, False if it’s not
        /// </return>
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();

            //Strip string of special chars
            List<char> newString = new List<char>();

            for (int i = 0; i < s.Length; i++)
                if (s[i] >= 'a' && s[i] <= 'z') newString.Add(s[i]);

            s = new string(newString.ToArray());

            //Reverse the string and stores a copy
            char[] charArr = s.ToCharArray();
            Array.Reverse(charArr);
            string reverse = new string(charArr);

            return s == reverse;
        }
    }
}
