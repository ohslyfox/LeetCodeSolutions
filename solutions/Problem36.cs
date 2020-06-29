using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem36
    {
        public static bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.') continue;
                    if (seen.Add($"{board[i][j]} in row {i}") == false ||
                        seen.Add($"{board[i][j]} in column {j}") == false ||
                        seen.Add($"{board[i][j]} in {i / 3} {j / 3}") == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
