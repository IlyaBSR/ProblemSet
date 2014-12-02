using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    public class BinaryTree
    {
        /* Find the largest sum in a BT using an aggregate of any continuous nodes */
        public static int LargestSum(TreeNode root)
        {
            int max = int.MinValue;

            int largestAtRoot = LargestSumHelper(root, ref max);

            return Math.Max(largestAtRoot, max);
        }

        private static int LargestSumHelper(TreeNode root, ref int max)
        {
            if (root != null)
            {
                int childrenMax = Math.Max(LargestSumHelper(root.Left, ref max), LargestSumHelper(root.Right, ref max));
                if (childrenMax > max)
                {
                    max = childrenMax;
                }

                return root.Data + childrenMax;
            }

            return 0;
        }

        /* Remove nodes not using any additional data structures or recursion */
        public static bool RemoveTree(ref TreeNode root)
        {
            // Validate inputs
            if (root == null) return false;
            if (root.Left == null && root.Right == null)
            {
                root = null;
                return true;
            }

            // Get leftmost Node
            TreeNode leftmost = LeftMostTreeNode(root);

            // Walk through the tree, every encounter of a right node, append it to the leftmost
            TreeNode cur = root;

            while (cur != null)
            {
                if (cur.Right != null)
                {
                    leftmost.Left = cur.Right;
                    cur.Right = null;
                    leftmost = LeftMostTreeNode(leftmost);
                }

                cur = cur.Left;
            }

            //Walk through the tree from the root and remove nodes along the way
            cur = root;

            while (cur.Left != null)
            {
                TreeNode next = cur.Left;
                cur = null;
                cur = next;
            }

            return true;
        }

        private static TreeNode LeftMostTreeNode(TreeNode root)
        {
            if (root == null) return null;
            if (root.Left == null) return root;

            TreeNode leftmost = root.Left;

            while (leftmost.Left != null)
            {
                leftmost = leftmost.Left;
            }

            return leftmost;
        }
    }
}
