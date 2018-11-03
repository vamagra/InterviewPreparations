using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    //  Design a HashSet without using any built-in hash table libraries.
    //  To be specific, your design should include these functions:
    //  add(value): Insert a value into the HashSet.
    //  contains(value) : Return whether the value exists in the HashSet or not.
    //  remove(value): Remove a value in the HashSet.If the value does not exist in the HashSet, do nothing.
    //  Example:
    //  MyHashSet hashSet = new MyHashSet();
    //  hashSet.add(1);         
    //  hashSet.add(2);         
    //  hashSet.contains(1);    // returns true
    //  hashSet.contains(3);    // returns false (not found)
    //  hashSet.add(2);          
    //  hashSet.contains(2);    // returns true
    //  hashSet.remove(2);          
    //  hashSet.contains(2);    // returns false (already removed)
    //  Note:
    //  All values will be in the range of[0, 1000000].
    //  The number of operations will be in the range of[1, 10000].
    //  Please do not use the built-in HashSet library.
    //  </summary>
    class DesignHashset
    {
        List<int> list;

        DesignHashset()
        {
            list = new List<int>();
        }

        public void Add(int x)
        {
            if(list.Contains(x))
            {
                return;
            }

            list.Add(x);
        }

        public bool contains(int x)
        {
            if (list.Contains(x))
            {
                return true;
            }

            return false;
        }

        public void remove(int key)
        {
            if(!list.Contains(key))
            {
                return;
            }

            list.Remove(key);
        }
    }
}
