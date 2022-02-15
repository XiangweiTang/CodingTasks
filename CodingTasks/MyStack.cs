using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    class MyStack
    {
        /// <summary>
        /// Initialize the custom stack.
        /// </summary>
        public MyStack()
        {
            // You may add your initializer here.
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the top element of the stack, and remove it.
        /// This action should take O(1) time.
        /// </summary>
        /// <returns>The top element</returns>
        public int Pop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Push one element into the stack.
        /// This action should take O(1) time.
        /// </summary>
        /// <param name="value">The element to be pushed.</param>
        public void Push(int value)
        {
            throw new NotImplementedException();
        }
    }
}
