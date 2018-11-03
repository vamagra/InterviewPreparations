using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PermutationsIIWithDuplicates
    {
        /// <summary>
        /// Given a collection of numbers that might contain duplicates, return all possible unique permutations.
        //        For example,
        //        [1, 1, 2] have the following unique permutations:
        //   [
        //      [1,1,2],
        //      [1,2,1],
        //       [2,1,1]
        //   ]
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> GetPermutationsWithDuplicates(int[] nums)
        {
            IList<IList<int>> resultedList = new List<IList<int>>();

            if (nums.Length < 1)
            {
                return resultedList;
            }

            Array.Sort(nums);

            Backtrack(resultedList, new List<int>(), nums, new bool[nums.Length]);

            return resultedList;
        }

        private static void Backtrack(IList<IList<int>> list, List<int> tempList, int[] nums, bool[] used)
        {
            if (tempList.Count == nums.Length)
            {
                list.Add(new List<int>(tempList));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (used[i] || i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                    {
                        continue;
                    }

                    tempList.Add(nums[i]);
                    used[i] = true;
                    Backtrack(list, tempList, nums, used);
                    used[i] = false;
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }
    }
}
