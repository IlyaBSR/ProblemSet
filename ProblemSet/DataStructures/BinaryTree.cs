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
    }
}
