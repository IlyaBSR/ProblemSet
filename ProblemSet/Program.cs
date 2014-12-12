using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSet.DataStructures;

namespace ProblemSet
{
    class Program
    {
        static void Main(string[] args)
        {
            LLNode<int> head = new LLNode<int>(1);
            LLNode<int> curr = head;
            for (int i = 2; i < 7; i++)
            {
                LLNode<int> n = new LLNode<int>(i);
                curr.Next = n;
                curr = n;
            }

            LinkedListMethods.PrintLinkedListBackwards(head);
        }
    }
}
