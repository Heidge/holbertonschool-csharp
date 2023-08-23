using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// New class
    /// </summary>
    public class Operations
    {
       /// <summary>
       /// New method
       /// </summary>
       /// <param name="nums"></param>
       /// <returns></returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;
            
            int maxInt = nums[0];

            for (int i = 0; i < nums.Count; i++) 
            {
                if (nums[i] > maxInt)
                {
                    maxInt = nums[i];
                }
            }
            return maxInt;
        }
    }
}
