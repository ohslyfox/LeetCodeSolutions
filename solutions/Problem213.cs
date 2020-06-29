using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem213
    {
        //public static int Rob(int[] nums)
        //{
        //    if (nums.Length == 0) return 0;
        //    if (nums.Length == 1) return nums[0];
        //    if (nums.Length > 3) nums[2] = -1 * (nums[2] + nums[0]);
        //    nums[0] *= -1;

        //    for (int i = 3; i < nums.Length; i++)
        //    {
        //        if (i == nums.Length - 1)
        //        {
        //            nums[i] += Math.Max(nums[i - 2], nums[i - 3]);
        //        }
        //        else
        //        {
        //            var twoBefore = Math.Abs(nums[i - 2]);
        //            var threeBefore = Math.Abs(nums[i - 3]);

        //            if (twoBefore > threeBefore)
        //            {
        //                nums[i] += twoBefore;
        //                if (nums[i - 2] < 0)
        //                {
        //                    nums[i] *= -1;
        //                }
        //            }
        //            else if (twoBefore <= threeBefore)
        //            {
        //                nums[i] += threeBefore;
        //                if (nums[i - 3] < 0)
        //                {
        //                    nums[i] *= -1;
        //                }
        //            }
        //        }
        //    }

        //    var m = Math.Max(Math.Abs(nums[nums.Length - 1]), Math.Abs(nums[nums.Length - 2]));
        //    return nums.Length > 2 ? Math.Max(m, Math.Abs(nums[nums.Length - 3])) : m;
        //}
    }
}
