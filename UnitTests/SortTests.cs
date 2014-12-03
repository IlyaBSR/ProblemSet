using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;
using System.Collections.Generic;

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
            SortMethods.SelectionSort(ref input);

            // Assert
            for (int i = 1; i < input.Length; i++)
            {
                Assert.IsTrue(input[i - 1] <= input[i]);
            }
        }

        [TestMethod]
        public void MergeSort()
        {
            // Arrange
            Random r = new Random();
            int[] input = new int[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = r.Next(input.Length);
            }
            List<int> inputList = new List<int>(input);

            // Act
            List<int> outputList = SortMethods.MergeSort(inputList);

            // Assert
            for (int i = 1; i < outputList.Count; i++)
            {
                Assert.IsTrue(outputList[i - 1] <= outputList[i]);
            }
        }

        [TestMethod]
        public void Merge()
        {
            // Arrange
            int[] A = new int[] { 1, 3, 5 };
            int[] B = new int[] { 2, 4, 6};

            // Act
            int[] output = SortMethods.Merge(A, B);

            // Assert
            Assert.AreEqual(6, output.Length);

            for (int i = 1; i < output.Length; i++)
            {
                Assert.IsTrue(output[i - 1] <= output[i]);
            }
        }
    }
}
