using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem109
    {
        public static TreeNode SortedListToBST(ListNode head)
        {
            List<int> normalList = ListNodeToList(head);
            return RecursiveBST(normalList);
        }

        private static TreeNode RecursiveBST(List<int> list)
        {
            if (list.Count == 0) return null;

            int mid = list.Count / 2;
            TreeNode res = new TreeNode(list[mid]);
            res.left = RecursiveBST(list.GetRange(0, mid));
            res.right = RecursiveBST(list.GetRange(mid + 1, list.Count - (mid + 1)));

            return res;
        }

        private static List<int> ListNodeToList(ListNode head)
        {
            List<int> res = new List<int>();
            while (head != null)
            {
                res.Add(head.val);
                head = head.next;
            }

            return res;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
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