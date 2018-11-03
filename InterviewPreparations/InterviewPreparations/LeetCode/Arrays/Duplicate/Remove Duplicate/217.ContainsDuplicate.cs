using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ContainsDuplicate
    {
        /// <summary>
        /// Given an array of integers, find if the array contains any duplicates. 
        /// Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool IsDuplicateInArray(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return false;
            }

            Hashtable mapping = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (mapping.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    mapping.Add(nums[i], nums[i]);
                }
            }

            return false;
        }
    }
}
