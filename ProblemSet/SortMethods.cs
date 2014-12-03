using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    public class SortMethods
    {
        public static void QuickSort(ref int[] input)
        {
            QuickSort(ref input, 0, input.Length);
        }

        public static void QuickSort(ref int[] input, int start, int end)
        {
            if (end <= start) return;

            int pivotIndex = start;

            for (int i = start; i < end; i++)
            {
                if (i == pivotIndex) continue;

                if (input[i] <= input[pivotIndex])
                {
                    if (i == pivotIndex + 1)
                    {
                        CommonMethods.Swap(ref input, i, pivotIndex);
                    }
                    else 
                    {
                        int temp = input[pivotIndex];
                        input[pivotIndex] = input[i];
                        input[i] = input[pivotIndex + 1];
                        input[pivotIndex + 1] = temp;
                    }

                    pivotIndex++;
                }
            }

            QuickSort(ref input, start, pivotIndex);
            QuickSort(ref input, pivotIndex + 1, end);
        }

        // Merge Sort using lists
        public static List<int> MergeSort(List<int> inputList)
        {
            if (inputList.Count < 2)
            {
                return inputList;
            }

            int middle = inputList.Count / 2;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for(int i = 0; i < middle; i++)
            {
                left.Add(inputList[i]);
            }

            for (int i = middle; i < inputList.Count; i++)
            {
                right.Add(inputList[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        public static List<int> Merge(List<int> A, List<int> B)
        {
            List<int> output = new List<int>();

            int indexA = 0, indexB = 0;

            while (indexA < A.Count || indexB < B.Count)
            {
                if (indexA != A.Count && indexB != B.Count)
                {
                    if (A[indexA] < B[indexB])
                    {
                        output.Add(A[indexA]);
                        indexA++;
                    }
                    else
                    {
                        output.Add(B[indexB]);
                        indexB++;
                    }
                }
                else if (indexA == A.Count)
                {
                    output.Add(B[indexB]);
                    indexB++;
                }
                else
                {
                    output.Add(A[indexA]);
                    indexA++;
                }
            }

            return output;
        }

        /* Implimentatin of Merge using Arrays */
        public static int[] Merge(int[] A, int[] B)
        {
            int[] outputArray = new int[A.Length + B.Length];

            int indexA = 0, indexB = 0;

            while (indexA < A.Length && indexB < B.Length)
            {
                if (A[indexA] < B[indexB])
                {
                    outputArray[indexA + indexB] = A[indexA];
                    indexA++;
                }
                else
                {
                    outputArray[indexA + indexB] = B[indexB];
                    indexB++;
                }
            }

            if (indexA == A.Length)
            {
                for( ; indexB < B.Length; indexB++)
                {
                    outputArray[indexA + indexB] = B[indexB];
                }
            }
            else
            {
                for (; indexA < A.Length; indexA++)
                {
                    outputArray[indexA + indexB] = A[indexA];
                }
            }

            return outputArray;
        }

        /* Implimentation of bubble sort.  O(N^2) */
        public static void BubbleSort(ref int[] inputArray)
        {
            for (int i = inputArray.Length; i > 0; i-- )
            {
                for (int j = 1; j < i; j++)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        CommonMethods.Swap(ref inputArray, j - 1, j);
                    }
                }
            }
        }

        /* Implimentation of selection sort. O(N^2) */
        public static void SelectionSort(ref int[] inputArray)
        {
            for(int i = 0; i < inputArray.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                { 
                    if (inputArray[j] < inputArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                CommonMethods.Swap(ref inputArray, minIndex, i);
            }
        }

        /* Implimentation of Insertion sort. O(N^2) */
        public static void InsertionSort(ref int[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (inputArray[j] > inputArray[j+1])
                    {
                        CommonMethods.Swap(ref inputArray, j, j + 1);
                    }
                }
            }
        }
    }
}
