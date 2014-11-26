using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;

namespace UnitTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void RemoveDuplicates()
        {
            // Arrange
            LLNode<int> head = new LLNode<int>(1);
            LLNode<int> curr = head;
            for (int i = 0; i < 5; i++)
            {
                LLNode<int> n = new LLNode<int>(i);
                curr.Next = n;
                curr = n;
            }

            // Act
            LLNode<int> clean = LinkedListMethods.RemoveDuplicates(head);

            // Assert
            Assert.AreEqual(clean.Data == 1, true);
            Assert.AreEqual(clean.Next.Data == 0, true);
            Assert.AreEqual(clean.Next.Next.Data == 2, true);
            Assert.AreEqual(clean.Next.Next.Next.Data == 3, true);
            Assert.AreEqual(clean.Next.Next.Next.Next.Data == 4, true);
        }
    }
}
