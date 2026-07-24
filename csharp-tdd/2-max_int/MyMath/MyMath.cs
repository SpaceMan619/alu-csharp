using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Provides mathematical operations.</summary>
    public class Operations
    {
        ///<summary>Returns the greatest integer in a list.</summary>
        /// <param name="nums">The integers to inspect.</param>
        /// <returns>The maximum integer, or zero for a null or empty list.</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            int maximum = nums[0];
            for (int index = 1; index < nums.Count; index++)
            {
                if (nums[index] > maximum)
                {
                    maximum = nums[index];
                }
            }

            return maximum;
        }
    }
}
