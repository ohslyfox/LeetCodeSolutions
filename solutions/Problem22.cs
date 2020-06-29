using System.Collections.Generic;

namespace LeetCode
{
    public static class Problem22
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> res = new List<string>();
            RecursiveGen(res, string.Empty, n, n, n);
            return res;
        }

        private static void RecursiveGen(List<string> res, string compiledString, int open, int close, int n)
        {
            if (compiledString.Length == 2 * n)
            {
                res.Add(compiledString);
                return;
            }

            if (open > 0)
            {
                RecursiveGen(res, compiledString + "(", open - 1, close, n);
            }
            if (close > open)
            {
                RecursiveGen(res, compiledString + ")", open, close - 1, n);
            }
        }
    }
}
