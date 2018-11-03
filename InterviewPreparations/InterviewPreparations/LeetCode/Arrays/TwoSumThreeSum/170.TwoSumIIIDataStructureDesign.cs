using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    //  Design and implement a TwoSum class. It should support the following operations: add and find.
    //  add - Add the number to an internal data structure.
    //  find - Find if there exists any pair of numbers which sum is equal to the value.
    //  For example,
    //  add(1);
    //  add(3);
    //  add(5);
    //  find(4) -> true
    //  find(7) -> false
    //  </summary>
    class TwoSumIIIDataStructureDesign
    {
        public static IDictionary<int, int> dict = new Dictionary<int, int>();

        public static void add(int data)
        {
            // Add the number in dictionary with frequency of number if duplicate
            if(dict.ContainsKey(data))
            {
                dict[data] = dict[data] + 1;
            }
            else
            {
                dict.Add(data, 1);
            }
        }

        public static bool find(int data)
        {
            foreach (int key in dict.Keys)
            {
                int target = data - key;

                // if duplicate number and dict count is greater than 1 return true
                // 2 == 2 => 4
                if (key == target && dict[target] > 1)
                {
                    return true;
                }

                // if not duplicate and dict contains that number return true
                else if (dict.ContainsKey(target))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
