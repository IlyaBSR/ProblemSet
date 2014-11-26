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

    }
}
