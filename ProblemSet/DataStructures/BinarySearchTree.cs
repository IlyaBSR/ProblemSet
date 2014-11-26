using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    public class BinarySearchTree
    {
        public static void Insert(ref TreeNode root, int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
            }
            else if (data < root.Data)
            {
                TreeNode left = root.Left;
                Insert(ref left, data);
                root.Left = left;
            } 
            else
            {
                TreeNode right = root.Right;
                Insert(ref right, data);
                root.Right = right;
            }
        }

        public static void DeleteNode(ref TreeNode root)
        {
            if (root == null) {
                return ; 
            }

            TreeNode parentNode = root;
            TreeNode leafNodeToReplace = null;

            if (root.Left == null && root.Right == null)
            {
                root = null;
                return;
            }
            else if (root.Left != null)
            {
                leafNodeToReplace = root.Left;
                
                // Grab smaller value than root
                while (leafNodeToReplace.Right != null)
                {
                    parentNode = leafNodeToReplace;
                    leafNodeToReplace = leafNodeToReplace.Right;
                }

            }
            else if (root.Right != null && root.Left == null)
            {
                leafNodeToReplace = root.Right;

                // Grab larger value than root
                while (leafNodeToReplace.Left != null)
                {
                    parentNode = leafNodeToReplace;
                    leafNodeToReplace = leafNodeToReplace.Left;
                }
            }

            root.Data = leafNodeToReplace.Data;
            if(parentNode.Left == leafNodeToReplace)
            {
                parentNode.Left = null;
            }
            else
            {
                parentNode.Right = null;
            }

            DeleteNode(ref leafNodeToReplace);
        }

        public static TreeNode Find(TreeNode root, int key)
        {
            if (key == root.Data)
            {
                return root;
            }
            else if (key < root.Data)
            {
                return Find(root.Left, key);
            }
            else if (key > root.Data)
            {
                return Find(root.Right, key);
            } else
            {
                return null;
            }
        }

        

        
    }
}
