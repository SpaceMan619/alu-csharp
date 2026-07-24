using System;

namespace Text
{
    /// <summary>Provides string operations.</summary>
    public static class Str
    {
        /// <summary>Determines whether text is a case-insensitive palindrome.</summary>
        /// <param name="s">The text to inspect.</param>
        /// <returns><c>true</c> when the text reads the same backward and forward.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
            {
                return false;
            }

            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }

                while (left < right && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
