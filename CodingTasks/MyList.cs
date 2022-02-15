using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{

    /// <summary>
    /// This class is a custom data structure of implenmenting List with Array.
    /// </summary>
    class MyList
    {
        /// <summary>
        /// Initialize the custom list.
        /// </summary>
        public MyList(int arraySize)
        {
            // You may add your initializer here.
            InternalArray = new int[arraySize];
            Length = 0;
        }

        /// <summary>
        /// Initialize the custom list. If no argument is specified, use 16 as default size.
        /// </summary>
        public MyList() : this(16)
        {

        }
        /// <summary>
        /// This array is the place where the values are stored.
        /// </summary>
        private int[] InternalArray = new int[0];
        /// <summary>
        /// The lengthe of the "List". 
        /// i.e.: 
        ///     If user doesn't insert anything, this value should be 0.
        ///     If user inserts 10 elements, this value should be 10.        
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// This function gets the {index}th element from the List(0 based). 
        /// The index could be invalid.
        /// This action should take O(1), or constant time.
        /// </summary>
        /// <param name="index">The index of the element you need.</param>
        /// <returns>The {index}th element.</returns>
        public int ElementAt(int index)
        {
            if (index < 0)
                throw new Exception("Index less than 0.");
            if (index >= Length)
                throw new Exception("Index out of boundary.");
            return InternalArray[index];
        }

        /// <summary>
        /// Add an element at the end of the List.
        /// This action should take O(1), or constant time.
        /// </summary>
        /// <param name="element">The element to be added.</param>
        public void Add(int element)
        {
            if (Length >= InternalArray.Length)
                throw new Exception("No more elements.");
            InternalArray[Length] = element;
            Length++;
        }

        /// <summary>
        /// Insert an element at the specific index.
        /// This action should take O(n) time, where n is the size of the array.
        /// </summary>
        /// <param name="element">The element to be inserted.</param>
        /// <param name="index">The index of the inserted element.</param>
        public void InsertAt(int element, int index)
        {
            if (Length >= InternalArray.Length)
                throw new Exception("No more elements.");
            if (index < 0)
                throw new Exception("Index less than 0.");
            if (index > Length)
                throw new Exception("Index out of boundary.");

            for (int i = Length - 1; i >= index; i--)
                InternalArray[i + 1] = InternalArray[i];

            InternalArray[index] = element;
            Length++;
        }

        /// <summary>
        /// Remove an element at the specific index.
        /// This action should take O(n) time, where n is the size of the array.
        /// </summary>
        /// <param name="index">The index to be removed.</param>
        public void RemoveAt(int index)
        {
            if (Length == 0)
                throw new Exception("List length is 0 already.");
            if (index < 0)
                throw new Exception("Index less than 0.");
            if (index >= Length)
                throw new Exception("Index out of boundary.");

            for (int i = index; i < Length - 1; i++)
                InternalArray[i] = InternalArray[i + 1];
            Length--;
        }
    }
}
