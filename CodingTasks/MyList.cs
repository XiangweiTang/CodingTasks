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
        public MyList()
        {
            // You may add your initializer here.
        }
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add an element at the end of the List.
        /// This action should take O(1), or constant time.
        /// </summary>
        /// <param name="element">The element to be added.</param>
        public void Add(int element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insert an element at the specific index.
        /// This action should take O(n) time, where n is the size of the array.
        /// </summary>
        /// <param name="element">The element to be inserted.</param>
        /// <param name="index">The index of the inserted element.</param>
        public void InsertAt(int element, int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove an element at the specific index.
        /// This action should take O(n) time, where n is the size of the array.
        /// </summary>
        /// <param name="index">The index to be removed.</param>
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }

    static class MyListHelper
    {
        public static void TestMyList()
        {
            MyList list = new MyList();
            list.Add(3);    //  {3}
            list.Add(122);  //  {3, 122}
            int i = list.ElementAt(4);  // Invalid input, since there is no element has an index of 4.
            i = list.ElementAt(1);  //  i=122, since 122 is the 1-th(0 based) element.
            list.Add(74);   //  {3, 122, 74}
            list.Add(92);   //  {3, 122, 74, 92}
            list.RemoveAt(2);   //  {3, 122, 92}, the 2-th element 74 is removed.
            list.InsertAt(27,1);   //   {3, 27, 122, 92}, 27 is inserted, its index is 1.
            list.RemoveAt(8);   // Invalid input, since there is no element has an index of 8.
        }
    }
}
