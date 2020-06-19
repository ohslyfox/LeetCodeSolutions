using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem102
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            AddToList(root, res, 0);
            return res;
        }

        public static void AddToList(TreeNode node, IList<IList<int>> res, int depth)
        {
            if (node == null) return;
            if (res.Count == depth)
            {
                res.Add(new List<int>());
            }

            res[depth].Add(node.val);
            AddToList(node.left, res, depth + 1);
            AddToList(node.right, res, depth + 1);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
