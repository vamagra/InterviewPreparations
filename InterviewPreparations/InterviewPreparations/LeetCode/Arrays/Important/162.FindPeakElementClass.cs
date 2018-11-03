using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// A peak element is an element that is greater than its neighbors.
    //  Given an input array where num[i] ≠ num[i + 1], find a peak element and return its index.
    //  The array may contain multiple peaks, in that case return the index to any one of the peaks is fine.
    //  You may imagine that num[-1] = num[n] = -∞.
    //  For example, in array[1, 2, 3, 1], 3 is a peak element and your function should return the index number 2.
    //  click to show spoilers.
    //  Note:
    //  Your solution should be in logarithmic complexity.
    /// </summary>
    /// 
    class FindPeakElementClass
    {
        public static int FindPeak(int[] nums)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            return HelperPeek(nums, 0, nums.Length - 1);
        }

        public static int HelperPeek(int[] nums, int start, int end)
        {
            // for one element in the array
            if (start == end)
            {
                return start;
            }

            // for two elements in array
            else if (start + 1 == end)
            {
                if (nums[start] > nums[end])
                {
                    return start;
                }
                else
                {
                    return end;
                }
            }
            else
            {
                //To get the peak element here we have below scenarios - 
                //1. if random choose element is greater than left and right than random number is peak element
                //2. if the left neighbor of random element is greater then we will find peak in left#####
                //3. if the right neighbor of random element is greater then we will find peak in right#####
                //4. By this point you should be able to get your Peak Element

                int mid = (start + end) / 2;

                //peak element is greater than its previous and next element
                if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                {
                    return mid;
                }
                //If previous element is greater than mid and mid is greater than next, peak will definetly in first half of the array
                else if (nums[mid] < nums[mid - 1])
                {
                    return HelperPeek(nums, start, mid - 1);
                }
                //else peak will second half
                else
                {
                    return HelperPeek(nums, mid + 1, end);
                }
            }
        }
    }
}
