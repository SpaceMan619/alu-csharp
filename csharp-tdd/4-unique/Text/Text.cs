namespace Text
{
    ///<summary>Provides string operations.</summary>
    public class Str
    {
        ///<summary>Finds the index of the first character that occurs once.</summary>
        /// <param name="s">A lowercase string.</param>
        /// <returns>The first unique character index, or <c>-1</c> when none exists.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            int[] counts = new int[26];
            for (int index = 0; index < s.Length; index++)
            {
                counts[s[index] - 'a']++;
            }

            for (int index = 0; index < s.Length; index++)
            {
                if (counts[s[index] - 'a'] == 1)
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
