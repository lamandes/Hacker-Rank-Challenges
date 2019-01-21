using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23BST_Level_Order_Traversal
{
    class Solution
    {
        static void levelOrder(Node root)
        {
            string szString = "";
            Queue<Node> queue = new Queue<Node>();
            if (root != null)
            {
                queue.Enqueue(root);
                //Continue when queue is not empty
                while (queue.Count != 0)
                {
                    //1. Get current root
                    Node currentRoot = queue.Dequeue();

                    //2. Process current root
                    szString += currentRoot.data + " ";

                    //3. Add left to queue
                    if (currentRoot.left != null)
                    {
                        queue.Enqueue(currentRoot.left);
                    }
                    //4. Add right to queue
                    if (currentRoot.right != null)
                    {
                        queue.Enqueue(currentRoot.right);
                    }
                }
            }

            //5. Finally, print out string
            Console.WriteLine(szString);
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}
