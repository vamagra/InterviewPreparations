using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Searching
{
    class BinarySearchClass
    {
        public static int BinarySearch(int[] nums, int startIndex, int endIndex, int target)
        {
            if (startIndex > endIndex)
            {
                return -1;
            }

            int mid = (startIndex + endIndex) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if(nums[mid] > target)
            {
                return BinarySearch(nums, startIndex, mid - 1, target);
            }
            else
            {
                return BinarySearch(nums, mid + 1, endIndex, target);
            }
        }
    }
}
