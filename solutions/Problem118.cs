using System.Collections.Generic;

namespace LeetCode
{
    public static class Problem118
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (numRows <= 0)
            {
                return res;
            }

            res.Add(new List<int> { 1 });
            for (int i = 1; i < numRows; i++)
            {
                var prevList = res[i - 1];
                var currList = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        currList.Add(1);
                    }
                    else
                    {
                        currList.Add(prevList[j - 1] + prevList[j]);
                    }
                }
                res.Add(currList);
            }
            return res;
        }
    }
}
