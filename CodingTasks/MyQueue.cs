using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    class MyQueue
    {
        private int[] InternalArray = new int[0];
        public MyQueue():this(16)
        {
            
        }

        public MyQueue(int capacity)
        {
            InternalArray = new int[capacity];
            Count = 0;
            HeadIndex = 0;
        }

        public int Count { get; private set; }
        private int HeadIndex = 0;

        /// <summary>
        /// Add element to the tail of the queue. Takes O(1) time.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Enqueue(int value)
        {
            if (Count == InternalArray.Length)
                throw new Exception("Queue overflow.");
            if (Count > InternalArray.Length)
                throw new Exception("Queue broken.");
            InternalArray[Tail()] = value;
            Count++;
        }

        /// <summary>
        /// Get the head of the queue, and remove it. Takes O(1) time.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Dequeue()
        {
            int peak = Peak();
            HeadIndex++;
            if (HeadIndex >= InternalArray.Length)
                HeadIndex -= InternalArray.Length;
            return peak;
        }

        /// <summary>
        /// Get the head of the queue. Takes O(1) time.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Peak()
        {
            if (Count == 0)
                throw new Exception("Queue underflow.");
            if (Count < 0 || HeadIndex < 0 || HeadIndex >= InternalArray.Length)
                throw new Exception("Queue broken");
            return InternalArray[HeadIndex];
        }

        private int Tail()
        {
            int tail = HeadIndex + Count;
            if (tail < 0)
                throw new Exception("Queue broken.");
            if (tail >= InternalArray.Length)
                tail -= InternalArray.Length;
            if (tail >= InternalArray.Length)
                throw new Exception("Queue broken.");
            return tail;
        }
    }
}
