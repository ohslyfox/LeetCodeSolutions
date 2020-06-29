using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem198
    {
        public static int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length >= 3) nums[2] += nums[0];
            for (int i = 3; i < nums.Length; i++)
            {
                nums[i] += Math.Max(nums[i - 2], nums[i - 3]);
            }

            return Math.Max(nums[nums.Length - 1], nums[nums.Length - 2]);
        }
    }
}
