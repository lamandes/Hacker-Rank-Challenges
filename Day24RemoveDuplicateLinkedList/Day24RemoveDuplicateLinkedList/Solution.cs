using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24RemoveDuplicateLinkedList
{
    class Solution
    {

        public static Node removeDuplicates(Node head)
        {
            Node cur = head;
            while(cur.next != null)
            {
                //1. Check if current node is same as next node
                if (cur.data == cur.next.data)
                {
                    cur.next = cur.next.next;
                    cur = head;                 //restart to eliminate 3 or more duplicates
                    continue;               
                }
                //2. Go to next node
                cur = cur.next;
            }
            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
