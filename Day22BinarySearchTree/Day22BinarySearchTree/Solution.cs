using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22BinarySearchTree
{
    class Solution
    {
        static int getHeight(Node root)
        {
            int leftHeight = 0;
            int rightHeight = 0;
            //Recursive equation for 1 + max(height(leftchild), height(rightchild))
            if (root.left != null)
            {
                leftHeight = 1 + getHeight(root.left);
            }
            if (root.right != null)
            {
                rightHeight = 1 + getHeight(root.right);
            }
            
            if(leftHeight > rightHeight)
            {
                return leftHeight;
            }
            else
            {
                return rightHeight;
            }
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
            //Create a null node as root.
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);

        }
    }
}
