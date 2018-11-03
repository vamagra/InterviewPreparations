using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SortColors012
    {
        /// <summary>
        /// Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, 
        // with the colors in the order red, white and blue.
        //  Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
        //  Note:
        //  You are not suppose to use the library's sort function for this problem.
        //  </summary>
        //  <param name="nums"></param>
        public static void Sort012(int[] nums)
        {
            if (nums.Length < 1)
            {
                return;
            }

            // Idea is quite simple here
            // have pivot=1 and three variables start, mid and end
            // start for 0, end=2 and mid=1
            // run the loop from mid to end
            // if mid<pivot, we hit 0, swap the values and increament mid and start
            // if mid>pivot, we hit 2, swap the values and decreament end
            // else we hit 1, just increment the mid

            int start = 0;
            int mid = 0;
            int end = nums.Length - 1;
            int pivot = 1;

            while (mid <= end)
            {
                if (nums[mid] < pivot) //for 0, if nums[mid] is 0 then swap start with mid and increament start and mid both
                {
                    //int temp = nums[mid];
                    //nums[mid] = nums[start];
                    //nums[start] = temp;
                    swap(nums, start, mid);
                    start++;
                    mid++;
                }
                else if (nums[mid] > pivot) // for 2, if nums[mid] is 2, swap mid with high and decreament high
                {
                    //int temp = nums[mid];
                    //nums[mid] = nums[end];
                    //nums[end] = temp;
                    swap(nums, mid, end);
                    end--;
                }
                else  // for 1, just increase mid
                {
                    mid++;
                }
            }
        }

        public static void swap(int[] nums, int num1, int num2)
        {
            int temp = nums[num1];
            nums[num1] = nums[num2];
            nums[num2] = temp;
        }
    }
}
