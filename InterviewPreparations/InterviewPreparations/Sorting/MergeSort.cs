using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Sorting
{
    class MergeSortClass
    {
        public static int[] MergeSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(nums, low, mid);
                MergeSort(nums, mid + 1, high);
                Merge(nums, low, mid, high);
            }
            return nums;
        }

        public static void Merge(int[] nums, int low, int mid, int high)
        {
            int i = 0, j = 0;

            int len1 = mid - low + 1;
            int len2 = high - mid;

            int[] left = new int[len1];
            int[] right = new int[len2];

            //Copy half of the array before mid into 1 array
            for (i = 0; i < len1; i++)
            {
                left[i] = nums[low + i];
            }

            //Copy second half of the array after mid into 2 array
            for (j = 0; j < len2; j++)
            {
                right[j] = nums[mid + 1 + j];
            }

            //Merge the temp array back to original array
            i = 0; j = 0;
            int k = low;

            while (i < len1 && j < len2)
            {
                if (left[i] < right[j])
                {
                    nums[k] = left[i];
                    i++;
                }
                else
                {
                    nums[k] = right[j];
                    j++;
                }

                k++;
            }

            //copy remaining elements from left half to original array if any

            while (i < len1)
            {
                nums[k] = left[i];
                i++;
                k++;
            }

            //copy remaining elements from right half to original array if any

            while (j < len2)
            {
                nums[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
