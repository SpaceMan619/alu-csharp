namespace Text
{
    ///<summary>Provides string operations.</summary>
    public class Str
    {
        ///<summary>Counts words in a camelCase string.</summary>
        /// <param name="s">The camelCase text.</param>
        /// <returns>The number of words in the text.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int words = 1;
            for (int index = 0; index < s.Length; index++)
            {
                if (char.IsUpper(s[index]))
                {
                    words++;
                }
            }

            return words;
        }
    }
}
