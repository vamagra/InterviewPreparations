using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays.Important
{
    class SearchInIncreasingDecresingArray
    {
        /// <summary>
        /// Given an array which is first strictly increasing and then strictly decreasing.Find an element in this array
        /// Consider this example: 1 4 5 6 7 10 8 3 2 0.
        //  In this example, if I need to find whether the sequence contains '2', 
        //  I do not have any conditions to divide the search space into half of the 
        //  original search space. In the worst, case it will be O
        //  (n), as you need to 
        //  check for both halves, when we are trying to search for 2.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SearchElement(int[] nums, int k)
        {
            return 0;
        //        if (nums.Length == 1)
        //        {
        //            return arr[0]
        //        }
         
        //if len(arr) in [0,2]:
        //    return None
        //left, right = 0, len(arr) - 1
        //while left <= right:
        //    mid = (left+right) // 2
        //    #increasing region
        //    if arr[mid + 1] >  arr[mid] and arr[mid] > arr[mid - 1]:
        //        left = mid + 1
        //    #decreasing region
        //    elif arr[mid + 1] < arr[mid] and arr[mid] < arr[mid - 1]:
        //        right = mid - 1
        //    elif arr[mid + 1] < arr[mid] and arr[mid - 1] > arr[mid]:
        //        return arr[mid - 1]
        //    else:
        //        return arr[mid]
        //return -1
        }

    }
}
