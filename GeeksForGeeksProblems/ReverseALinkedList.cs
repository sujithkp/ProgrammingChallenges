using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems
{
    public class Node
    {
        public int Value;

        public Node Next;

        public Node(int value)
        {
            this.Value = value;
        }

    }

    class ReverseALinkedList
    {
        public void Run()
        {
            var arr = new int[] { 2, 7, 8, 9, 10 };

            Node head = ConstructLinkedList(arr);

            Node newHead = Reverse(head);

        }

        public Node Reverse(Node curr)
        {
            Node prev = null;
            Node next = null;

            while (curr != null)
            {
                next = curr.Next;

                curr.Next = prev;
                prev = curr;

                if (next == null)
                    return curr;

                curr = next;       
            }

            return curr;

        }

        public Node ConstructLinkedList(int[] arr)
        {
            Node head = null, curr = null;

            foreach (var element in arr)
            {
                if (head == null)
                {
                    head = curr = new Node(element);
                    continue;
                }

                curr.Next = new Node(element);
                curr = curr.Next;
            }

            return head;
        }

    }
}
