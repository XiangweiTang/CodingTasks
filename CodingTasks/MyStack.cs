using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    class MyStack
    {
        int[] InternalArray = new int[0];        
        /// <summary>
        /// Initialize the custom stack.
        /// </summary>
        public MyStack():this(16)
        {
            
        }

        public MyStack(int capacity)
        {
            InternalArray = new int[capacity];
            Count = 0;
        }

        /// <summary>
        /// The count of the elements inside the stack.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Get the top element of the stack, without remove it.
        /// This action should take O(1) time.
        /// </summary>
        /// <returns>The top element</returns>
        public int Peak()
        {
            if (Count == 0)
                throw new Exception("Stack underflow.");
            if (Count < 0 || Count > InternalArray.Length)
                throw new Exception("Stack broken.");
            return InternalArray[Count - 1];
        }

        /// <summary>
        /// Get the top element of the stack, and remove it.
        /// This action should take O(1) time.
        /// </summary>
        /// <returns>The top element</returns>
        public int Pop()
        {
            int peak = Peak();
            Count--;
            return peak;
        }

        /// <summary>
        /// Push one element into the stack.
        /// This action should take O(1) time.
        /// </summary>
        /// <param name="value">The element to be pushed.</param>
        public void Push(int value)
        {
            if (Count == InternalArray.Length)
                throw new Exception("Stack overflow.");
            if (Count > InternalArray.Length)
                throw new Exception("Stack broken.");
            InternalArray[Count] = value;
            Count++;
        }
    }
}
