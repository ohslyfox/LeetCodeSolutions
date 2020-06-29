using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public static class Problem15
    {
        //public static IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    IList<IList<int>> res = new List<IList<int>>();

        //    List<HashSet<int>> sets = new List<HashSet<int>>();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        HashSet<int> seen = new HashSet<int>();
        //        int target = -1 * nums[i];
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            int needed = target - nums[j];
        //            if (seen.Contains(needed))
        //            {
        //                var list = new List<int> { -1 * target, needed, nums[j] };
        //                sets.Add(new HashSet<int>(list));
        //                res.Add(list);
        //            }
        //            seen.Add(nums[j]);
        //        }
        //    }

        //    // remove dupes
        //    for (int i = 0; i < res.Count; i++)
        //    {
        //        var set = sets[i];
        //        for (int j = i + 1; j < res.Count; j++)
        //        {
        //            if (set.SetEquals(sets[j]))
        //            {
        //                res.RemoveAt(j);
        //                sets.RemoveAt(j);
        //                j--;
        //            }
        //        }
        //    }

        //    return res;
        //}
    }
}
