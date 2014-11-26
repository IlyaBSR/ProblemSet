using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet.DataStructures;

namespace UnitTests
{
    [TestClass]
    public class QueueStackTests
    {
        [TestMethod]
        public void QueueOfStacks_Basic()
        {
            // Arrange
            QueueOfStacks q = new QueueOfStacks();

            // Act
            for (int i = 0; i < 10; i++)
            {
                q.Enqueue(i);
            }

            // Assert
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(i, q.Dequeue());
            }
        }

        [TestMethod]
        public void StackOfQueues_Basic()
        {
            // Arrange
            StackOfQueues stack = new StackOfQueues();

            // Act
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            // Assert
            for (int i = 9; i >= 0; i--)
            {
                Assert.AreEqual(i, stack.Pop());
            }
        }
    }
}
