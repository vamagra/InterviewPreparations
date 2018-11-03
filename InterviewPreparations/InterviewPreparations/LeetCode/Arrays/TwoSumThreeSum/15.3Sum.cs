using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace InterviewQuestions.LeetCode
{
    class _3Sum
    {
        /// <summary>
        //   Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
        //        Note: The solution set must not contain duplicate triplets.
        //        For example, given array S = [-1, 0, 1, 2, -1, -4],
        //        A solution set is:
        //[
        //          [-1, 0, 1],
        //          [-1, -1, 2]
        //]
        // </summary>
        // <param name="nums"></param>
        // <returns></returns>
        
        public static List<List<int>> ThreeSumWithSort(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            //Sort the Array First
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i - 1 >= 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int left = i + 1;
                int right = nums.Length - 1 ;
                int x = nums[i];

                while (left < right)
                {
                    if (x + nums[left] + nums[right] == 0)
                    {
                        List<int> list = new List<int>();
                        list.Add(x);
                        list.Add(nums[left]);
                        list.Add(nums[right]);
                        result.Add(list);

                        //Skip Duplicates
                        while (left + 1 < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }

                        while (right - 1 > left && nums[right] == nums[right - 1])
                        {
                            right--;
                        }

                        left++;
                        right--;
                    }
                    else if (x + nums[left] + nums[right] < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            int i = 0;
            int length = nums.Length - 1;

            IList<IList<int>> retu = new List<IList<int>>();
            List<int> list = null;

            for (i = 0; i <= length; i++)
            {
                list = new List<int>();
                for (int j = i + 1; j <= length; j++)
                {
                    int x = -(nums[i] + nums[j]);

                    if (list.Contains(x))
                    {
                        retu.Add(new List<int>
                        {
                            x,
                            nums[i],
                            nums[j]
                        });
                    }
                    else
                    {
                        list.Add(nums[j]);
                    }
                }
            }

            return retu;
        }
    }
}
