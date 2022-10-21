//https://leetcode.com/problems/palindrome-linked-list/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.LeetCode
{

    public class LinkedList<T>
    {
        public ListNode Head { get; private set; }

        public LinkedList(IList<int> elements)
        {
            Init(elements);
        }

        private void Init(IList<int> elements)
        {
            if (elements == null || elements.Count == 0)
                return;

            var prev = this.Head = new ListNode(elements[0]);

            for (int i = 1; i < elements.Count; i++)
                prev.next = new ListNode(elements[i]);
        }

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

    public class LinkedlistPalindrome
    {
        public bool IsPalindrome(ListNode head)
        {
            var stack = new Stack<int>();

            var curr = head;

            while (curr != null)
            {
                stack.Push(curr.val);
                curr = curr.next;
            }

            curr = head;

            while (curr != null)
            {
                if (curr.val != stack.Pop())
                    return false;

                curr = curr.next;
            }

            return true;
        }
    }
}
