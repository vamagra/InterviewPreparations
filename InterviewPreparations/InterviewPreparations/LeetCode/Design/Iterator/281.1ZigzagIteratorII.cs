using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Design
{
    /// <summary>
    //  Follow up Zigzag Iterator: What if you are given k 1d vectors? How well can your code be extended to
    //  such cases? The "Zigzag" order is not clearly defined and is ambiguous for k > 2 cases. If "Zigzag" does
    //  not look right to you, replace "Zigzag" with "Cyclic".
    //  Have you met this question in a real interview? Yes Example Given k = 3 1d vectors:Follow up Zigzag 
    //  Iterator: What if you are given k 1d vectors? How well can your code be extended to such cases? 
    //  The "Zigzag" order is not clearly defined and is ambiguous for k > 2 cases.If "Zigzag" does not look right 
    //  to you, replace "Zigzag" with "Cyclic".
    //  Have you met this question in a real interview? Yes Example Given k = 3 1d vectors:
    //  </summary>
    class ZigzagIteratorII
    {
        public List<IEnumerator<int>> listIterator;
        public int turns;

        public ZigzagIteratorII(List<List<int>> vLists)
        {
            listIterator = new List<IEnumerator<int>>();

            foreach(List<int> list in vLists)
            {
                if (list.Count > 0)
                {
                    listIterator.Add(list.GetEnumerator());
                }
            }

            turns = 0;
        }

        public int next()
        {
            // get the next element;
            int elem = listIterator[turns].Current;

            // check if curr list has next element
            if (listIterator[turns].MoveNext())
            {
                // if next element is there next move the turns to next list;
                turns = (turns + 1) % listIterator.Count; 
            }
            else
            {
                // if it was the last element of list, remove that from list of iterator
                listIterator.RemoveAt(turns);

                // check if there are more list in listIterator
                if (listIterator.Count > 0)
                {
                    // if yes update the turns 
                    turns = turns % listIterator.Count;
                }
            }

            return elem;
        }

        public bool hasNext()
        {
            return listIterator.Count > 0;
        }
    }
}
