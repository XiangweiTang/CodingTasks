using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    class MyQueue
    {
        public MyQueue()
        {
            
        }

        public int Count { get; private set; }

        /// <summary>
        /// Add element to the tail of the queue. Takes O(1) time.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Enqueue(int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the head of the queue, and remove it. Takes O(1) time.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Dequeue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the head of the queue. Takes O(1) time.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Peak()
        {
            throw new NotImplementedException();
        }
    }
}
