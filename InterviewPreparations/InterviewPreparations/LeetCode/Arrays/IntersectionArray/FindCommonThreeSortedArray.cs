using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FindCommonThreeSortedArray
    {
        /// <summary>
        /// Given three arrays sorted in non-decreasing order, print all common elements in these arrays.
        //  Examples:
        //  ar1[] = {1, 5, 10, 20, 40, 80}
        //  ar2[] = {6, 7, 20, 80, 100}
        //  ar3[] = {3, 4, 15, 20, 30, 70, 80, 120}
        //  Output: 20, 80
        //  ar1[] = {1, 5, 5}
        //  ar2[] = {3, 4, 5, 5, 10}
        //  ar3[] = {5, 5, 10, 20}
        //  Output: 5, 5
        //  </summary>
        //  <param name="arr1"></param>
        //  <param name="arr2"></param>
        //  <param name="arr3"></param>
        //  <returns></returns>
        public static List<int> FindCommon(int[] arr1, int[] arr2, int[] arr3)
        {
            List<int> result = new List<int>();
            if ((arr1 == null || arr1 != null && arr1.Length < 1) || (arr2 == null || arr2 != null && arr2.Length < 1) || (arr3 == null || arr3 != null && arr3.Length < 1))
            {
                return result;
            }

            int i = 0;
            int j = 0;
            int k = 0;

            int n1 = arr1.Length;
            int n2 = arr2.Length;
            int n3 = arr3.Length;

            while (i < n1 && j < n2 && k < n3)
            {
                if ((arr1[i] == arr2[j]) && (arr2[j] == arr3[k]))
                {
                    result.Add(arr1[i]);
                    i++;
                    j++;
                    k++;
                }
                else if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if(arr2[j] < arr3[k])
                {
                    j++;
                }
                else
                {
                    k++;
                }
            }

            return result;
        }
    }
}
