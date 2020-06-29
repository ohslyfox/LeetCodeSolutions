using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem83
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode res = null;
            HashSet<int> set = new HashSet<int>();

            ListNode temp = null;
            while (head != null)
            {
                if (set.Contains(head.val) == false)
                {
                    set.Add(head.val);
                    var next = new ListNode(head.val);
                    if (res == null)
                    {
                        res = temp = next;
                    }
                    else
                    {
                        temp.next = next;
                        temp = next;
                    }
                }
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
    }
}
