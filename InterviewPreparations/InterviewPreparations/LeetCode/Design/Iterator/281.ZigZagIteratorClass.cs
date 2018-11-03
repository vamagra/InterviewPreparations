using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    /// Given two 1d vectors, implement an iterator to return their elements alternately.
    //  For example, given two 1d vectors:
    //  v1 = [1, 2]
    //  v2 = [3, 4, 5, 6]
    //  By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1, 3, 2, 4, 5, 6].
    //  Follow up: What if you are given k 1d vectors? How well can your code be extended to such cases?
    //  Clarification for the follow up question - Update(2015-09-18): The "Zigzag" order is not clearly defined and is ambiguous for k > 2 cases.If "Zigzag" does not look right to you, replace "Zigzag" with "Cyclic". For example, given the following input:
    //  [1,2,3]
    //  [4,5,6,7]
    //  [8,9]
    //  It should return [1,4,8,2,5,9,3,6,7].
    //  Follow up: What if you are given k 1d vectors? How well can your code be extended to such cases?
    //  Clarification for the follow up question - Update(2015-09-18): The "Zigzag" order is not clearly defined and is ambiguous for k > 2 cases.If "Zigzag" does not look right to you, replace "Zigzag" with "Cyclic". For example, given the following input:
    //  [1,2,3]
    //  [4,5,6,7]
    //  [8,9]
    //  It should return [1,4,8,2,5,9,3,6,7].
    /// </summary>
    public class ZigZagIteratorIEnumeratorClass
    {
        #region Solution Approach 1 - Use IEnumerator
        // Using two iterators, alternatively calling get the next element from each iterator when call next() method 
        // for the ZigzagIterator object. If one iterator reaches to the end, then call the other one only 
        #endregion

        IEnumerator<int> it1;
        IEnumerator<int> it2;

        int turns;

        public ZigZagIteratorIEnumeratorClass(List<int> v1, List<int> v2)
        {
            this.it1 = v1.GetEnumerator();
            this.it2 = v2.GetEnumerator();
            this.turns = 0;
        }

        public int next()
        {
            if(!hasNext())
            {
                return 0;
            }

            turns++;

            // If it is the odd number and the first list also has the next element, return the next one of the first list
            // If the second list is not already there, return to the next one of the first list
            if (turns % 2 == 1 && it1.MoveNext() || (!it2.MoveNext()))
            {
                return it1.Current;
            }

            // If it is the even number and the second list also has the next element, return to the next one of the second list
            // If the first list is not already there, return to the next one of the second list
            else if (turns % 2 == 0 && it2.MoveNext() || (!it1.MoveNext()))
            {
                return it2.Current;
            }

            return 0;
        }

        public bool hasNext()
        {
            return it1.MoveNext() && it2.MoveNext();
        }
    }

    public class ZigZagIteratorCustomIterator
    {
        List<int> list1;
        List<int> list2;

        bool zigZag;
        int index = 0;

        ZigZagIteratorCustomIterator(List<int> v1, List<int> v2)
        {
            list1 = v2;
            list2 = v2;

            zigZag = true;
            index = 0;
        }

        public int next()
        {
            int result = 0;

            if (zigZag && index < list1.Count)
            {
                result = list1[index++];

                // if index is less than list2, then list2 has elements to read
                if (index < list2.Count)
                {
                    zigZag = !zigZag;
                }
            }
            else
            {
                result = list2[index++];

                if (index < list1.Count)
                {
                    zigZag = !zigZag;
                }
            }

            return result;
        }

        public bool hasNext()
        {
            return index < list1.Count && index < list2.Count;
        }
    }
}
