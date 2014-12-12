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

        [TestMethod]
        public void AddBigIntegers_LLN()
        {
            // Act
            string output = LinkedListMethods.AddBigIntegers("1238", "1238");

            // Assert
            Assert.AreEqual("2476", output);
        }

        [TestMethod]
        public void AddBigIntegers_LLN_Complex()
        {
            // Act
            string output = LinkedListMethods.AddBigIntegers("9238", "1238");

            // Assert
            Assert.AreEqual("10476", output);
        }

        [TestMethod]
        public void FindEntryNode()
        {
            // Arrange
            LLNode<int> head = new LLNode<int>(1);
            LLNode<int> curr = head;
            for (int i = 2; i < 7; i++)
            {
                LLNode<int> n = new LLNode<int>(i);
                curr.Next = n;
                curr = n;
            }

            LLNode<int> end = curr;
            curr = head;
            for (int i = 0; i < 2; i++)
            {
                curr = curr.Next;
            }
            end.Next = curr;

            // Act
            LLNode<int> output = LinkedListMethods.FindEntryOfLoop(head);

            // Assert
            Assert.AreEqual(curr, output);
        }
    }
}
