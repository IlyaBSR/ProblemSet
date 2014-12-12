using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSet;
using System.Collections.Generic;
using ProblemSet.DataStructures;

namespace UnitTests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void BinarySearch()
        {
            // Arrange
            int[] input1 = new int[] { 0, 1, 2, 3, 4, 5 };
            int[] input2 = new int[] { 0 };
            int[] input3 = new int[] { 1, 5, 8 };
            
            // Act
            bool output1 = ArrayMethods.BinarySearch(input1, 0);
            bool output2 = ArrayMethods.BinarySearch(input1, 5);
            bool output3 = ArrayMethods.BinarySearch(input1, 2);
            bool output4 = ArrayMethods.BinarySearch(input1, 10);
            bool output5 = ArrayMethods.BinarySearch(input2, 0);
            bool output6 = ArrayMethods.BinarySearch(input2, 1);
            bool output7 = ArrayMethods.BinarySearch(input3, 5);

            // Assert
            Assert.IsTrue(output1);
            Assert.IsTrue(output2);
            Assert.IsTrue(output3);
            Assert.IsFalse(output4);
            Assert.IsTrue(output5);
            Assert.IsFalse(output6);
            Assert.IsTrue(output7);
        }

        [TestMethod]
        public void MatrixContains()
        {
            // Arrange
            int[,] matrix1 = new int[,]
            {{1,3,5},
             {7,9, 11},
             {13, 15, 17}};

            // Act
            Assert.IsTrue(ArrayMethods.MatrixContains(matrix1, 7));
            Assert.IsFalse(ArrayMethods.MatrixContains(matrix1, 8));
            Assert.IsTrue(ArrayMethods.MatrixContains(matrix1, 1));
            Assert.IsTrue(ArrayMethods.MatrixContains(matrix1, 17));
           
        }
        
        [TestMethod]
        public void MergeArraysWorked()
        {
            // Arrange
            int[] A = new int[] { 0, 2, 4, 6, 0, 0, 0 };
            int[] B = new int[] { 1, 3, 4 };


            // Act
            ArrayMethods.MergeArrays(ref A, B, 3, B.Length - 1);

            // Assert
            Assert.AreEqual(A[0], 0);
            Assert.AreEqual(A[1], 1);
            Assert.AreEqual(A[2], 2);
            Assert.AreEqual(A[3], 3);
            Assert.AreEqual(A[4], 4);
            Assert.AreEqual(A[5], 4);
            Assert.AreEqual(A[6], 6);
        }

        [TestMethod]
        public void AnagramStringArraySortWorked()
        {
            // Arrange
            string[] input = { "abc", "abcd", "acbd", "aaddeeff", "a", "dcda" };

            // Act
            ArrayMethods.SortAnagrams(ref input);
            
            // Assert
            Assert.AreEqual(input[0], "a");
            Assert.AreEqual(input[1], "abc");
            Assert.AreEqual(input[5], "aaddeeff");
            Assert.IsTrue(input[2] == "abcd" || input[2] == "acbd");
            Assert.IsTrue(input[3] == "abcd" || input[3] == "acbd");
            Assert.IsTrue(input[4] == "dcda");
        }

        [TestMethod]
        public void FindKInRotatedTest()
        {
            // Arrange
            int[] input = new int[] { 15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14 };

            // Act
            int result = ArrayMethods.FindKInShiftedArray(input, 14);

            // Assert
            Assert.AreEqual(result, 11);
        }

        [TestMethod]
        public void FindKInRotatedTest_WithDups()
        {
            // Arrange
            int[] input = new int[] { 10, 10, 12, 12, 15, 16, 2, 8, 8, 9};

            // Act
            int result = ArrayMethods.FindKInShiftedArray(input, 16);

            // Assert
            Assert.AreEqual(result, 5);
        }

    [TestMethod]
        public void FindKInRotatedTest_DoesntExist()
        {
            // Arrange
            int[] input = new int[] { 15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14 };

            // Act
            int result = ArrayMethods.FindKInShiftedArray(input, 2);

            // Assert
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void PartitionArrayByK_Works()
        {
            // Arrange
            int[] input = new int[] { 10, 8, 2, 4, 3, 9, 4, 1 };

            // Act
            ArrayMethods.PartitionArrayByIndex(ref input, 3);

            // Assert
            for (int i = 0; i < 3; i++)
            {
                Assert.IsTrue(input[i] < 4);
            }

            for (int i = 3; i < 5; i++)
            {
                Assert.IsTrue(input[i] == 4);
            }

            for (int i = 5; i < input.Length; i++)
            {
                Assert.IsTrue(input[i] > 4);
            }
        }

        [TestMethod]
        public void IsReachableTest_True()
        {
            // Arrange
            int[] input = new int[] { 3, 3, 1, 0, 2, 0, 1 };

            // Act
            bool result = ArrayMethods.EndReachable(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsReachableTest_False()
        {
            // Arrange
            int[] input = new int[] { 3, 2, 0, 0, 2, 0, 1 };

            // Act
            bool result = ArrayMethods.EndReachable(input);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void DeleteKey_Found()
        {
            // Arrange
            int[] input = new int[]{1, 2, 3, 4, 4, 5, 7, 8};

            // Act
            int result = ArrayMethods.DeleteKeyFromArray(ref input, 4);

            // Assert
            Assert.AreEqual(2, result);

            for (int i = 0; i < input.Length; i++)
            {
                Assert.IsTrue(input[i] != 4);
            }
        }

        [TestMethod]
        public void RemoveDuplicates()
        {
            // Arrange
            int[] input = new int[] { 1, 2, 3, 5, 5, 7, 11, 11, 11, 13};

            // Act
            ArrayMethods.RemoveDuplicatesFromArray(ref input);

            // Assert
            for (int i = 1; i < 7; i++)
            {
                Assert.IsTrue(input[i] != input[i - 1]);
            }
        }

        [TestMethod]
        public void FindValueInMatrix()
        {
            // Arrange
            int[,] matrix1 = new int[,]
            {{1,3,5},
             {7,9, 11},
             {7, 15, 17}};

            // Act
            List<Coordinate> output = ArrayMethods.FindValueInMatrix(matrix1, 7);

            // Assert
            Assert.AreEqual(2, output.Count);
            Assert.IsTrue(output.Contains(new Coordinate { x = 1, y = 0 }));
            Assert.IsTrue(output.Contains(new Coordinate { x = 2, y = 0 }));
        }

        [TestMethod]
        public void NextPermutationBasic()
        {
            // Arrange
            List<int> inputList = new List<int>{1, 0, 3, 2};

            // Act
            List<int> outputList = ArrayMethods.NextPermutation(inputList);

            // Assert
            Assert.AreEqual(inputList.Count, outputList.Count);
            Assert.IsTrue(outputList[0] == 1 && outputList[1] == 2 && outputList[2] == 0 && outputList[3] == 3);
        }
    }

        
}
