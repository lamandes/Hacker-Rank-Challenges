using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15LinkedList
{
    class Solution
    {
        public static Node insert(Node head, int data)
        {
            Node tail = new Node(data);         //1. Create a new node and insert data into it
            if (head != null)                   //2. Check if head already assigned before, yes then change each pointer while it reach null
            {
                Node oringinalHead = head;      //3. Save original head node pointer
                while (head.next != null)
                {
                    head = head.next;
                }             
                head.next = tail;               //4. Update last node and Insert the new node into last node
                return oringinalHead;
            }
            else
            {
                return tail;
            }
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
            display(head);
        }
    }
}
