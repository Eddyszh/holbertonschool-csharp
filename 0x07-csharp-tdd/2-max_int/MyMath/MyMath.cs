using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Operations class
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the max integer in a list of integers
        /// </summary>
        /// <return>
        /// max integer in list, if nums is empty, return 0
        /// </return>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0) return 0;
            //Init max value with the first item in list
            int max = nums[0];

            foreach (var item in nums)
                max = Math.Max(max, item);

            return max;
        }
    }
}
