using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem9
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int reverse = ReverseInt(x);

            return x == reverse;
        }

        private static int ReverseInt(int x)
        {
            int res = 0;
            while (x > 0)
            {
                int lastDigit = x % 10;
                x /= 10;
                res = (res * 10) + lastDigit;
            }

            return res;
        }
    }
}
