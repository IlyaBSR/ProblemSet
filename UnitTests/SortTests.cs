using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;

namespace UnitTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void QuickSort()
        {
            // Arrange
            Random r = new Random();
            int[] input = new int[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = r.Next(input.Length);
            }

            // Act
            SortMethods.QuickSort(ref input);

            // Assert
            for (int i = 1; i < input.Length; i++)
            {
                Assert.IsTrue(input[i - 1] <= input[i]);
            }
        }

        [TestMethod]
        public void BubbleSort()
        {
            // Arrange
            Random r = new Random();
            int[] input = new int[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = r.Next(input.Length);
            }

            // Act
            SortMethods.BubbleSort(ref input);

            // Assert
            for (int i = 1; i < input.Length; i++)
            {
                Assert.IsTrue(input[i - 1] <= input[i]);
            }
        }

        [TestMethod]
        public void SelectionSort()
        {
            // Arrange
            Random r = new Random();
            int[] input = new int[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = r.Next(input.Length);
            }

            // Act
            SortMethods.SelectionSort(ref input);

            // Assert
            for (int i = 1; i < input.Length; i++)
            {
                Assert.IsTrue(input[i - 1] <= input[i]);
            }
        }

        [TestMethod]
        public void InsertionSort()
        {
            // Arrange
            Random r = new Random();
            int[] input = new int[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = r.Next(input.Length);
            }

            // Act
            SortMethods.InsertionSort(ref input);

            // Assert
            for (int i = 1; i < input.Length; i++)
            {
                Assert.IsTrue(input[i - 1] <= input[i]);
            }
        }
    }
}
