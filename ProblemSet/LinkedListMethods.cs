using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    public class LinkedListMethods
    {
        public static LLNode<int> DeleteNode(LLNode<int> head, int k)
        {
            if (head.Data == k) return head.Next;

            LLNode<int> curr = head;
            LLNode<int> prev = null;

            while (curr != null)
            {
                if (curr.Data == k)
                {
                    prev.Next = curr.Next;
                    return head;
                }

                prev = curr;
                curr = curr.Next;
            }

            return null;
        }

        public static void DeleteNode(LLNode<int> v)
        {
            if (v == null || v.Next == null) return;

            LLNode<int> next = v.Next;
            v.Data = next.Data;
            v.Next = next.Next;
        }

        public static LLNode<int> ReverseLL(LLNode<int> head)
        {
            LLNode<int> curr = head;
            LLNode<int> prev = null;
            LLNode<int> output = null;

            while (curr != null)
            {
                LLNode<int> temp = curr.Next;
                curr.Next = prev;
                output = curr;
                prev = curr;
                curr = temp;
            }

            return output;
        }

        public static LLNode<int> MergeSortedLLs(LLNode<int> L, LLNode<int> R)
        {
            LLNode<int> mergeHead = null;
            LLNode<int> tail = null;

            while (L != null && R != null)
            {
                if (L.Data < R.Data)
                {
                    AppendLLNodeAndAdvance(ref mergeHead, ref tail, ref L);
                }
                else
                {
                    AppendLLNodeAndAdvance(ref mergeHead, ref tail, ref R);
                }
            }

            if (L == null)
            {
                AppendLLNode(ref mergeHead, ref tail, ref R);
            }
            else
            {
                AppendLLNode(ref mergeHead, ref tail, ref L);
            }

            return mergeHead;
        }

        public static void AppendLLNode(ref LLNode<int> head, ref LLNode<int> tail, ref LLNode<int> node)
        {
            if (head != null)
            {
                tail.Next = node;
            }
            else
            {
                head = node;
            }

            tail = node;
        }

        public static void AppendLLNodeAndAdvance(ref LLNode<int> head, ref LLNode<int> tail, ref LLNode<int> node)
        {
            AppendLLNode(ref head, ref tail, ref node);

            node = node.Next;
        }

        public static bool IsCyclicLL(LLNode<int> head)
        {
            LLNode<int> slowRunner = head;
            LLNode<int> fastRunner = head;

            while (fastRunner != null)
            {
                slowRunner = slowRunner.Next;
                if (fastRunner.Next != null)
                {
                    fastRunner = fastRunner.Next.Next;
                }
                else fastRunner = null;

                if (slowRunner == fastRunner) return true;
            }

            return false;
        }

        public static bool IsPalindrome(LLNode<int> head)
        {
            Stack<int> stack = new Stack<int>();

            LLNode<int> slowRunner = head;
            LLNode<int> fastRunner = head;
            bool odd = false;

            while (fastRunner != null)
            {
                stack.Push(slowRunner.Data);

                slowRunner = slowRunner.Next;

                if (fastRunner.Next != null) fastRunner = fastRunner.Next.Next;
                else
                {
                    odd = true;
                    fastRunner = null;
                }
            }

            if (odd) stack.Pop();

            while (slowRunner != null)
            {
                if (slowRunner.Data != stack.Pop())
                {
                    return false;
                }

                slowRunner = slowRunner.Next;
            }

            return true;
        }

        public static void PrintLLN(LLNode<int> head)
        {
            LLNode<int> curr = head;

            while (curr != null)
            {
                Console.Write("{0} -> ", curr.Data);
                curr = curr.Next;
            }

            Console.WriteLine();
        }

        public static bool IsCyclic(LLNode<int> head)
        {
            LLNode<int> slow = head.Next;
            LLNode<int> fast = head;

            while (fast != slow)
            {
                slow = slow.Next;
                if (fast.Next == null)
                {
                    return false;
                }
                fast = fast.Next.Next;
            }

            return true;
        }

        public static LLNode<int> RemoveDuplicates(LLNode<int> head)
        {
            HashSet<int> S = new HashSet<int>();
            LLNode<int> curr = head;
            LLNode<int> prev = null;

            while (curr != null)
            {
                if (S.Contains(curr.Data))
                {
                    prev.Next = curr.Next;
                }
                else
                {
                    S.Add(curr.Data);
                    prev = curr;
                }
                curr = curr.Next;
            }

            return head;
        }

        private static LLNode<int> ConvertStringToLLN(string input)
        {
            LLNode<int> newHead = new LLNode<int>(int.Parse(input[input.Length - 1].ToString()));
            LLNode<int> cur = newHead;

            for (int i = input.Length - 2; i >= 0; i--)
            {
                if (input[i] == '-')
                {
                    break;
                }

                LLNode<int> newNode = new LLNode<int>(int.Parse(input[i].ToString()));
                cur.Next = newNode;
                cur = newNode;
            }

            return newHead;
        }

        public static string AddBigIntegers(string num1, string num2)
        {
            // Validate input
            if (String.IsNullOrEmpty(num1) && string.IsNullOrEmpty(num2))
            {
                return string.Empty;
            }
            else if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2))
            {
                return string.IsNullOrEmpty(num1) ? num2 : num1;
            }

            StringBuilder output = new StringBuilder();
            bool positiveOutput = true;

            // Convert strings to linked lists nodes
            LLNode<int> num1Head = ConvertStringToLLN(num1);
            LLNode<int> num2Head = ConvertStringToLLN(num2);

            // Add values
            LLNode<int> cur2 = num2Head;
            LLNode<int> cur = num1Head;
            bool carry = false;

            while (cur != null && cur2 != null)
            {
                int value = (cur != null ? cur.Data : 0) + (cur2 != null ? cur2.Data : 0) + (carry ? 1 : 0);
                if (value > 9)
                {
                    carry = true;
                    value -= 10;
                }
                else
                {
                    carry = false;
                }
                output.Append(value);

                cur = cur.Next;
                cur2 = cur2.Next;
            }

            if (carry)
            {
                output.Append(1);
            }

            if (!positiveOutput)
            {
                output.Append('-');
            }

            return StringMethods.ReverseString(output.ToString());
        }

        public static LLNode<int> KToLastElement(LLNode<int> head, int k)
        {
            LLNode<int> curr = head;

            for (int i = 0; i < k; i++)
            {
                if (curr == null) return null;
                curr = curr.Next;
            }

            if (curr == null) return null;

            LLNode<int> kNode = head;

            while (curr != null)
            {
                curr = curr.Next;
                kNode = kNode.Next;
            }

            return kNode;
        }
    }
}
