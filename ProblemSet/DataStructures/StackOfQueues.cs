using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    public class StackOfQueues
    {
        Queue<int> inputQueue;

        public StackOfQueues()
        {
            this.inputQueue = new Queue<int>();
        }

        public void Push(int input)
        {
            this.inputQueue.Enqueue(input);
        }

        public int Pop()
        {
            if (this.Count == 0) 
                throw new InvalidOperationException("Stack is empty, Pop is invalid");

            Queue<int> q = new Queue<int>();

            while (this.Count > 1)
            {
                q.Enqueue(this.inputQueue.Dequeue());
            }

            int output = this.inputQueue.Dequeue();
            this.inputQueue = q;

            return output;
        }

        public int Count
        {
            get
            {
                return this.inputQueue.Count;
            }
        }
    }
}
