using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem3
    {
        // this is a bad solution

        public static int LengthOfLongestSubstring(string s)
        {
            int res = 0;

            HashSet<char> seen = null;
            bool ok = false;
            for (int i = 0; i < s.Length && !ok; i++)
            {
                seen = new HashSet<char>();
                ok = true;
                int count = 0;
                for (int j = i; j < s.Length && ok; j++)
                {
                    if (seen.Contains(s[j]) == false)
                    {
                        seen.Add(s[j]);
                        count++;
                    }
                    else
                    {
                        ok = false;
                    }

                    if (count > res)
                    {
                        res = count;
                    }
                }
            }

            return res;
        }
    }
}
