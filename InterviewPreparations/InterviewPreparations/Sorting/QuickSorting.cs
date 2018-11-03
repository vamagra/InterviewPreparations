using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class QuickSorting
    {
        public static void QuickSort(int[] nums, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pi = Partitions(nums, leftIndex, rightIndex);

                if (pi > 1)
                {
                    QuickSort(nums, leftIndex, pi - 1);
                }

                if (pi + 1 < rightIndex)
                {
                    QuickSort(nums, pi + 1, rightIndex);
                }
            }
        }

        private static int Partitions(int[] nums, int leftIndex, int rightIndex)
        {
            int pivot = nums[leftIndex];

            while (true)
            {
                while (pivot > nums[leftIndex])
                {
                    leftIndex++;
                }

                while (pivot < nums[rightIndex])
                {
                    rightIndex--;
                }


                if (leftIndex < rightIndex)
                {
                    swap(ref nums[leftIndex], ref nums[rightIndex]);
                }
                else
                {
                    return rightIndex;
                }
            }
        }

        private static void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
