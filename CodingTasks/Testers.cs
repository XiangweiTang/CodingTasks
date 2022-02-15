using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    static class MyListTester
    {
        public static void TestMyList()
        {
            MyList list = new MyList();
            list.Add(3);    //  {3}
            list.Add(122);  //  {3, 122}
            //int i = list.ElementAt(4);  // Invalid input, since there is no element has an index of 4.
            int i = list.ElementAt(1);  //  i=122, since 122 is the 1-th(0 based) element.
            list.Add(74);   //  {3, 122, 74}
            list.Add(92);   //  {3, 122, 74, 92}
            list.RemoveAt(2);   //  {3, 122, 92}, the 2-th element 74 is removed.
            list.InsertAt(27, 1);   //  {3, 27, 122, 92}, 27 is inserted, its index is 1.
            list.InsertAt(38, 2);   //  {3, 27, 38, 122, 92}
            list.RemoveAt(8);   // Invalid input, since there is no element has an index of 8.
        }
    }
}
