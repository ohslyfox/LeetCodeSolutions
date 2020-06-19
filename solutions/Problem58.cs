using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem58
    {
        public static int LengthOfLastWord(string s)
        {
            if (s.Length == 0) return 0;
            string[] parts = s.Trim().Split(" ");
            return parts[parts.Length - 1].Length;
        }
    }
}
