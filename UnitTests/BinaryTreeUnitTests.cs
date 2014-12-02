using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet.DataStructures;

namespace UnitTests
{
    [TestClass]
    public class BinaryTreeUnitTests
    {
        [TestMethod]
        public void LargestSum_Basic()
        {
            // Arrange
            TreeNode tn = new TreeNode(0);
            tn.Left = new TreeNode(2);
            tn.Left.Right = new TreeNode(-1);
            tn.Left.Left = new TreeNode(-2);
            tn.Left.Left.Left = new TreeNode(4);
            tn.Right = new TreeNode(2);
            tn.Right.Left = new TreeNode(-4);
            tn.Right.Right = new TreeNode(-1);
            tn.Right.Right.Right = new TreeNode(4);

            // Act
            int output = BinaryTree.LargestSum(tn);

            // Assert
            Assert.AreEqual(5, output);
        }

        [TestMethod]
        public void RemoveNodes_NoExtras()
        {
            // Arrange
            TreeNode tn = new TreeNode(0);
            tn.Left = new TreeNode(2);
            tn.Left.Right = new TreeNode(-1);
            tn.Left.Left = new TreeNode(-2);
            tn.Left.Left.Left = new TreeNode(4);
            tn.Right = new TreeNode(2);
            tn.Right.Left = new TreeNode(-4);
            tn.Right.Right = new TreeNode(-1);
            tn.Right.Right.Right = new TreeNode(4);

            // Act
            bool output = BinaryTree.RemoveTree(ref tn);

            // Assert
            Assert.IsTrue(output);
        }
    }
}
