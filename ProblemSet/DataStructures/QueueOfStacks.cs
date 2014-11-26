using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    public class QueueOfStacks
    {
        private Stack<int> inputStack;
        private Stack<int> outputStack;

        public QueueOfStacks()
        {
            this.inputStack = new Stack<int>();
            this.outputStack = new Stack<int>();
        }

        public int Count
        {
            get
            {
                return this.inputStack.Count + this.outputStack.Count;
            }
        }

        public void Enqueue(int input)
        {
            this.inputStack.Push(input);
        }

        public int Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Unable to dequeue an empty queue");
            }

            if (this.outputStack.Count == 0)
            {
                while (this.inputStack.Count > 0)
                {
                    this.outputStack.Push(this.inputStack.Pop());
                }
            }

            return this.outputStack.Pop();
        }
    }
}
