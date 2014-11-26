using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    /// <summary>
    /// Max Heap data structure
    /// </summary>
    public class Heap
    {
        private int capacity = 10;
        private int[] heapContent;
        private Dictionary<int, int> rankCounts;
        private int size;

        public Heap()
        {
            this.CreateHeap();
            this.rankCounts = new Dictionary<int, int>();
        }

        public void CreateHeap()
        {
            this.heapContent = new int[this.capacity];
            this.size = 0;
        }

        public int Peek()
        {
            return heapContent[1];
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public void Insert(int input)
        {
            if (this.size + 1 == this.capacity)
            {
                Array.Resize(ref this.heapContent, this.capacity * 2);
                this.capacity *= 2;
            }

            int index = size + 1;
            this.heapContent[index] = input;
            this.size++;
            this.Track(input);

            index = this.ShiftUp(index);
        }

        public int ExtractMax()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Heap is empty");
            int output = this.heapContent[1];

            this.heapContent[1] = this.heapContent[size];
            this.size--;
            this.ShiftDown(1);

            return output;
        }

        private int ShiftDown(int index)
        {
            if (index < 1) return index;

            while (true)
            {
                if (index * 2 <= size && this.heapContent[index] < this.heapContent[index * 2])
                {
                    CommonMethods.Swap(ref this.heapContent, index, index * 2);
                    index *= 2;
                } 
                else if (index * 2 + 1 <= size && this.heapContent[index] < this.heapContent[index * 2 + 1])
                {
                    CommonMethods.Swap(ref this.heapContent, index, index * 2 + 1);
                    index *= 2 + 1;
                }
                else
                {
                    return index;
                }
            }
        }

        private void Track(int x)
        {
            if (!this.rankCounts.ContainsKey(x))
            {
                this.rankCounts.Add(x, 1);
            }
            else
            {
                this.rankCounts[x]++;
            }
        }

        public int GetRankOfNumber(int x)
        {
            int count = 0;

            IEnumerable<int> lowerRanks = this.rankCounts.Keys.Where(k => k <= x);

            foreach (int num in lowerRanks)
            {
                count += this.rankCounts[num];
            }

            if (lowerRanks.Contains(x))
            {
                count--;
            }

            return count;
        }

        private int ShiftUp(int index)
        {
            while (this.heapContent[index] > this.heapContent[index/2] && index != 1)
            {
                CommonMethods.Swap(ref this.heapContent, index, index / 2);
                index /= 2;
            }

            return index;
        }
    
    }
}