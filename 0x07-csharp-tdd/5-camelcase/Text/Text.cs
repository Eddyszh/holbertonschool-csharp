using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        ///  determines how many words are in a string. Each word begins with a capital letter except the first word
        /// </summary>
        /// <return>
        /// number of words in s
        /// </return>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length <= 0) return 0;

            //variable to count the words
            int count = 1;
            //variable to iterate in s
            int i = 0;

            if (s[0] >= 'A' || s[0] <= 'Z') i++;

            while (i < s.Length)
            {
                if (s[i] >= 'A' && s[i] <= 'Z') count++;
                i++;
            }

            return count;
        }
    }
}
