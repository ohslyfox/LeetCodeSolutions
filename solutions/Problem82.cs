using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public static class Problem82
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode res = null;
            Dictionary<int, int> itemToCount = new Dictionary<int, int>();
            while (head != null)
            {
                if (itemToCount.ContainsKey(head.val))
                {
                    itemToCount[head.val]++;
                }
                else
                {
                    itemToCount[head.val] = 1;
                }
                head = head.next;
            }

            var distinct = itemToCount.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToList();
            distinct.Sort();
            ListNode temp = null;
            foreach (var item in distinct)
            {
                var next = new ListNode(item);
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
