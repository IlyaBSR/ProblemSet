using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSet.DataStructures;

namespace ProblemSet
{
    public class ArrayMethods
    {
        // Binary Search implimentation of an already sorted integer array
        public static bool BinarySearch(int[] inputArray, int k)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException();
            }

            int start = 0, end = inputArray.Length - 1;
            int mid = (start + end) / 2;

            while (start <= end)
            {
                if (inputArray[mid] > k)
                {
                    end = mid - 1;
                }
                else if (inputArray[mid] < k)
                {
                    start = mid + 1;
                }
                else
                {
                    return true;
                }

                mid = (start + end) / 2;
            }

            return false;
        }

        /* CCI 11.1
         * You are given sorted arrays A and B, where A has a large enough buffer
         * at the end to hold B. Write a method to sort B into A in sorted order
         */
        public static void MergeArrays(ref int[] A, int[] B, int lastA, int lastB)
        {
            // Input validation
            if (A == null || A.Length < lastA || A.Length < (lastA + lastB))
            {
                throw new ArgumentException();
            }

            if (B == null) return;

            // Implimentation
            for(int i = A.Length -1; i >= 0; i--) {
                if (lastA < 0 || B[lastB] > A[lastA]) {
                    A[i] = B[lastB--];
                    if (lastB < 0) break;
                } else {
                    Swap(ref A, i, lastA--);
                }
            }
        }

        /* CCI 11.2 
         * Sort the Anagrams close together in an array of strings
         */
        public static void SortAnagrams(ref string[] input)
        {
            Array.Sort(input, new AnagramComparer());
        }

        /* CCI 11.3 
         * Given a sorted array of n integers that has been rotated an unkonwn number of times,
         * write code to find an element in the array.  You may assume that the array was
         * originally sorted in increasing order */
        public static int FindKInShiftedArray(int[] input, int k)
        {
            if (input == null) return -1;

            int start = 0;
            int end = input.Length - 1;
            int mid = (start + end) / 2;

            while (start < mid)
            {
                if (input[mid] == k) return mid;
                if (input[start] < k && input[end] < k) {
                    if (input[mid] < k)
                    {
                        start = mid;
                    }
                    else
                    {
                        end = mid;
                    }
                }
                    
                else
                    start = mid;
                mid = (start + end) / 2;
            }

            if (input[start] == k) return start;
            if (input[end] == k) return end;

            return -1;
        }

        public List<Coordinate> FindPath(int[,] maze, Coordinate start, Coordinate end)
        {
            List<Coordinate> visited = new List<Coordinate>();

            if (FindPathHelper(maze, start, end, ref visited))
            {
                return visited;
            }

            return null;
        }

        private bool FindPathHelper(int[,] maze, Coordinate cur, Coordinate dest, ref List<Coordinate> visited)
        {
            int[] dirX = new int[] { -1, 1, 0, 0 };
            int[] dirY = new int[] { 0, 0, 1, -1 };

            for (int i = 0; i < dirX.Length; i++)
            {
                Coordinate step;
                step.x = cur.x + dirX[i];
                step.y = cur.y + dirY[i];

                visited.Add(cur);

                if (step.Equals(dest))
                {
                    return true;
                }

                if (IsValidStep(step, maze, visited))
                {
                    FindPathHelper(maze, step, dest, ref visited);
                }

                visited.Remove(cur);
            }

            return false;
        }

        private bool IsValidStep(Coordinate step, int[,] maze, List<Coordinate> visited)
        {
            return step.x >= 0 && step.y >= 0
                && step.x < maze.GetLength(0) && step.y < maze.GetLength(1)
                && maze[step.x, step.y] == 1 && !visited.Contains(step);
        }

        public static void PartitionArrayByIndex(ref int[] A, int index)
        {
            int p2 = A.Length;
            Swap(ref A, 0, index);
            index = 0;

            for (int i = 1; i < p2; i++)
            {
                if (A[i] > A[index])
                {
                    Swap(ref A, i, p2 - 1);
                    p2--;
                    i--;
                }
                else if (A[i] < A[index])
                {
                    Swap(ref A, i, index);
                    index++;
                }
            }
        }

        /* EPI 6.4 Check if a game is winnable */
        public static bool EndReachable(int[] input)
        {
            int maxReached = 0;
            int lastReached = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i > maxReached) return false;

                lastReached = i + input[i];
                if (maxReached < lastReached)
                {
                    maxReached = lastReached;
                }
            }
                
            return true;
        }

        public static int DeleteKeyFromArray(ref int[] input, int k)
        {
            int firstK = -1;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > k && firstK > 0)
                {
                    input[firstK] = i;
                    firstK++;
                }
                else if (input[i] == k)
                {
                    if (firstK < 0)
                    {
                        firstK = i;
                    }

                    count++;
                }
            }

            return count;
        }

        /* EPI 6.6 Remove duplicates from an array */
        public static void RemoveDuplicatesFromArray(ref int[] input)
        {
            int firstDup = -1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1] && firstDup < 0)
                {
                    firstDup = i;
                }
                else if (firstDup > 0 && input[i] != input[firstDup])
                {
                    input[firstDup] = input[i];
                        firstDup++;
                }
            }
        }

        /* EPI 6.14 Compute next permutation
         * Given a permutation p represented as a vector, return the vector
         * corresponding to the next permutation under lexicographic ordering.  
         * If p is the last perutation, return empty vector. */
        public static List<int> NextPermutation(List<int> inputList)
        {
            // Validate input
            if (inputList == null) throw new ArgumentNullException();
            if (inputList.Count < 2)
            {
                return inputList;
            }

            // Iterate from the end to start to find valid digit to pivot from
            int pivotIndex = -1;
            for (int i = inputList.Count - 2; i >= 0; i--)
            {
                if (inputList[i] < inputList[i+1])
                {
                    pivotIndex = i;
                    break;
                }
            }

            // If pivot was not set that means none exists: EX: 4321
            if (pivotIndex < 0)
            {
                return new List<int>();
            }

            // Find the next larger number after the pivot index
            int nextLargerIndex = pivotIndex + 1;
            for (int i = pivotIndex + 2; i < inputList.Count; i++)
            {
                if (inputList[i] >= inputList[pivotIndex] + 1 && inputList[i] < inputList[nextLargerIndex])
                {
                    nextLargerIndex = i;
                }
            }

            // Swap that next larger with location after the pivot index
            Swap(ref inputList, pivotIndex, nextLargerIndex);

            // Sort the remaining values after pivot index + 1
            for (int i = pivotIndex + 1; i < inputList.Count; i++)
            {
                for (int j = i + 1; j < inputList.Count; j++)
                {
                    if (inputList[i] > inputList[j])
                    {
                        Swap(ref inputList, i, j);
                    }
                }
            }

            return inputList;
        }

        /// <summary>
        /// In a 2-D matrix, every row is increasingly sorted from left to right, and every
        /// column is increasing sorted from top to bottom. Impliment a function to find all
        /// coordinates of the passed value
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<Coordinate> FindValueInMatrix(int[,] matrix, int value)
        {
            // Validate input
            if (matrix == null) throw new ArgumentNullException("Matrix cannot be null");
            
            List<Coordinate> output = new List<Coordinate>();

            int row = 0;
            int column = matrix.GetLength(1) - 1; // Last column in matrix

            while (row < matrix.GetLength(0) && column >= 0)
            {
                if (matrix[row, column] == value)
                {
                    int tempX = row;
                    int tempY = column;

                    while (tempY >= 0 && matrix[tempX, tempY] == value)
                    {
                        Coordinate foundLoc = new Coordinate { x = tempX, y = tempY-- };
                        if (!output.Contains(foundLoc))
                        {
                            output.Add(foundLoc);
                        }
                    }

                    tempY = column;
                    tempX++;
                    while (tempX < matrix.GetLength(0) && matrix[tempX, tempY] == value)
                    {
                        Coordinate foundLoc = new Coordinate { x = tempX++, y = tempY };
                        if (!output.Contains(foundLoc))
                        {
                            output.Add(foundLoc);
                        }
                    }

                    row++;
                    column--;
                }
                else if (matrix[row, column] > value)
                {
                    column--;
                }
                else
                {
                    row++;
                }
            }

            return output;
        }

        /// <summary>
        /// CI 7 In a 2-D matrix, every row is increasingly sorted from left to right
        /// and the last number in each row is not great than the first number of the next row
        /// Impliment a function to check whter a number is in such a matrix or not
        /// </summary>
        /// <param name="matrix">2-D matrix</param>
        /// <param name="value">Value to verfiy</param>
        /// <returns></returns>
        public static bool MatrixContains(int[,] matrix, int value)
        {
            // Check input
            if (matrix == null) throw new ArgumentNullException();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int start = 0;
            int end = rows * cols - 1;
            int mid = (start + end) / 2;

            while (start <= end)
            {
                int midRow = mid / cols;
                int midCol = mid % cols;

                int v = matrix[midRow, midCol];

                if (v == value)
                {
                    return true;
                }

                if (v < value)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

                mid = (start + end) / 2;
            }

            return false;
        }

        private static void Swap(ref List<int> inputList, int index1, int index2)
        {
            if (index1 == index2) return;

            int temp = inputList[index1];
            inputList[index1] = inputList[index2];
            inputList[index2] = temp;
        }

        private static void Swap(ref int[] input, int index1, int index2)
        {
            if (index1 == index2) return;

            int temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;
        }
    }

    public class AnagramComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            if (a.Length < b.Length) return -1;
            else if (a.Length > b.Length) return 1;

            int[] aCounts = new int[256];

            foreach (char c in a)
            {
                aCounts[c]++;
            }

            foreach (char c in b)
            {
                aCounts[c]--;
                if (aCounts[c] < 0) return 1;
            }

            return 0;
        }
    }
}
