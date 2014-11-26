using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet.DataStructures;

namespace UnitTests
{
    [TestClass]
    public class HeapTests
    {
        [TestMethod]
        public void MaxHeapBasic()
        {
            // Arrange
            Heap heap = new Heap();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                heap.Insert(r.Next(30));
            }

            heap.Insert(35);

            // Act
            int result = heap.Peek();
            int result2 = heap.ExtractMax();

            // Assert
            Assert.AreEqual(result, 35);
            Assert.AreEqual(result, result2);
            Assert.IsTrue(heap.Size == 10);
        }

        [TestMethod]
        public void MaxHeap_1Item()
        {
            // Arrange
            Heap heap = new Heap();

            heap.Insert(35);

            // Act
            int result = heap.Peek();
            int result2 = heap.ExtractMax();

            // Assert
            Assert.AreEqual(result, 35);
            Assert.AreEqual(result, result2);
            Assert.IsTrue(heap.Size == 0);
        }

        [TestMethod]
        public void GetRankOfNumber_Basic()
        {
            // Arrange
            Heap h = new Heap();
            h.Insert(5);
            h.Insert(4);
            h.Insert(4);
            h.Insert(5);
            h.Insert(9);
            h.Insert(7);
            h.Insert(13);
            h.Insert(1);
            h.Insert(3);

            // Act
            int rank1 = h.GetRankOfNumber(1);
            int rank3 = h.GetRankOfNumber(3);
            int rank4 = h.GetRankOfNumber(4);

            // Assert
            Assert.AreEqual(0, rank1);
            Assert.AreEqual(1, rank3);
            Assert.AreEqual(3, rank4);
        }
    }
}
