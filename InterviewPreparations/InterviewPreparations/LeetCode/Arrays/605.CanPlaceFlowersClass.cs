using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class CanPlaceFlowersClass
    {
        /// <summary>
        /// Suppose you have a long flowerbed in which some of the plots are planted and some are not. However, flowers cannot be planted in adjacent plots - they would compete for water and both would die.
        //  Given a flowerbed(represented as an array containing 0 and 1, where 0 means empty and 1 means not empty), and a number n, return if n new flowers can be planted in it without violating the no-adjacent-flowers rule.
        //  Example 1:
        //  Input: flowerbed = [1, 0, 0, 0, 1], n = 1
        //  Output: True
        //  Example 2:
        //  Input: flowerbed = [1, 0, 0, 0, 1], n = 2
        //  Output: False
        //  Note:
        //  The input array won't violate no-adjacent-flowers rule.
        //  The input array size is in the range of[1, 20000].
        //  n is a non-negative integer which won't exceed the input array size.
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="n"></param>
        //  <returns></returns>
        public static bool CanPlace(int[] nums, int n)
        {
            if (n > nums.Length)
            {
                return false;
            }

            if (nums.Length < 1)
            {
                return false;
            }

            if (nums.Length == 1 && n == 0)
            {
                return true;
            }

            if (nums.Length == 1 && n == 1)
            {
                if (nums[0] != 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int counter = 0;
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] != 1 && n > 0)
                {
                    if (i == 0 && nums[i + 1] == 0)
                    {
                        counter++;
                        nums[i] = 1;
                    }
                    else if (i != 0 && i + 1 != nums.Length && nums[i - 1] == 0 && nums[i + 1] == 0)
                    {
                        counter++;
                        nums[i] = 1;
                    }
                    else if (i == nums.Length - 1 && nums[i - 1] == 0)
                    {
                        counter++;
                        nums[i] = 1;
                    }
                }
                i++;
            }

            return counter >= n;
        }
            
    }
}
