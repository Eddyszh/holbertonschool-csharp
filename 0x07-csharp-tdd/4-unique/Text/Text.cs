using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// returns the index of the first non-repeating character of a string
        /// </summary>
        /// <return>
        /// index of first non-repeating character or -1 if there is no non-repeating character
        /// </return>
        public static int UniqueChar(string s)
        {
            if (s == null) return -1;

            if (s.Length == 1) return 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i + 1).Contains(s[i].ToString()) == false &&
                    s.Substring(0, i).Contains(s[i].ToString()) == false)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
