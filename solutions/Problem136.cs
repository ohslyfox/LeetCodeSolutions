namespace LeetCode
{
    public static class Problem136
    {
        public static int SingleNumber(int[] nums)
        {
            int res = 0;
            foreach (var item in nums)
            {
                res ^= item;
            }
            return res;
        }
    }
}
