using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
     //  Design a data structure that supports all following operations in average O(1) time.
    //  insert(val): Inserts an item val to the set if not already present.
    //  remove(val): Removes an item val from the set if present.
    //  getRandom: Returns a random element from current set of elements.Each element must have the same probability of being returned.
    //  Example:
    //  Init an empty set.
    //  RandomizedSet randomSet = new RandomizedSet();

    //    // Inserts 1 to the set. Returns true as 1 was inserted successfully.
    //    randomSet.insert(1);

    //// Returns false as 2 does not exist in the set.
    //randomSet.remove(2);

    //// Inserts 2 to the set, returns true. Set now contains [1,2].
    //randomSet.insert(2);

    //// getRandom should return either 1 or 2 randomly.
    //randomSet.getRandom();

    //// Removes 1 from the set, returns true. Set now contains [2].
    //randomSet.remove(1);

    //// 2 was already in the set, so return false.
    //randomSet.insert(2);

    //// Since 2 is the only number in the set, getRandom always return 2.
    //randomSet.getRandom();
    ///</summary>    
    class RandomizedSet
    {
        #region Solution Explained
        // The List is used to store numbers and serve the getRandom() method.
        // The Map contains the mapping between the value and its index in the 
        // ArrayList.The Map helps to check whether a value is already inserted or not. 
        // The main trick is when you remove a value.ArrayList's remove method is O(n) 
        // if you remove from random location. To overcome that, we swap the values between 
        // (randomIndex, lastIndex) and always remove the entry from the end of the list. 
        // After the swap, you need to update the new index of the swapped value (which was previously at the end of the list) in the map.
        #endregion
        IDictionary<int, int> mapping;
        List<int> list;

        public RandomizedSet()
        {
            mapping = new Dictionary<int, int>();
            list = new List<int>();
        }

        public bool Insert(int data)
        {
            if (mapping.ContainsKey(data))
            {
                return false;
            }

            list.Add(data);
            mapping.Add(data, list.Count - 1);
            return true;
        }

        public bool Remove(int data)
        {
            if(!mapping.ContainsKey(data))
            {
                return false;
            }

            //get the index of random data
            int location = mapping[data];

            //Swap the last element
            if (location < list.Count - 1)
            {
                // here we are replacing the value of last element to random index
                int lastElement = list[list.Count - 1];
                list[location] = lastElement;

                // update the index in mapping for last element
                mapping[lastElement] = location;
            }

            //remove the last item from 
            list.RemoveAt(list.Count - 1);

            //remove the entry from mapping
            mapping.Remove(data);

            return true;
        }

        public int GetRandom()
        {
            int max = list.Count();
            Random random = new Random();
            int ind = (random.Next(max));
            return list[ind];
        }
    }
}
