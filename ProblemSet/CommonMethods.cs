using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSet.DataStructures;

namespace ProblemSet
{
    public class CommonMethods
    {
        public static void Swap(ref int[] A, int index1, int index2) {
            int temp = A[index1];
            A[index1] = A[index2];
            A[index2] = temp;
        }

        public static void PrintArray<T> (string tag, T[] input) {
            Console.WriteLine(tag);

            foreach (T obj in input)
            {
                Console.Write("{0} ", obj.ToString());
            }
            Console.WriteLine();
        }

        public static void PrintInOrder(TreeNode root)
        {
            if (root != null)
            {
                PrintInOrder(root.Left);
                Console.Write("{0} ", root.Data);
                PrintInOrder(root.Right);
            }
        }
    }
}
