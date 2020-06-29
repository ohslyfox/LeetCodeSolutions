using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem4
    {
        // this is a bad solution
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double res = 0d;
            List<int> list = new List<int>();
            list.AddRange(nums1);
            list.AddRange(nums2);
            list.Sort();

            int mid = list.Count / 2;
            if (list.Count % 2 == 0)
            {
                res = (double)(list[mid] + list[mid - 1]) / 2;
            }
            else
            {
                res = (double)list[mid];
            }
            return res;
        }
    }
}
