using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class Permutations
    {
        /// <summary>
        /// Given a collection of distinct numbers, return all possible permutations.
        //        For example,
        //        [1, 2, 3] have the following permutations:
        //  [
        //      [1,2,3],
        //      [1,3,2],
        //      [2,1,3],
        //      [2,3,1],
        //      [3,1,2],
        //      [3,2,1]
        //  ]
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ListPermutations(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length < 1)
            {
                return result;
            }

            Backtrack(result, new List<int>(), nums);

            return result;
        }

        private static void Backtrack(IList<IList<int>> list, List<int> tempList, int[] nums)
        {
            // this is condition when we got our permutation
            if (tempList.Count == nums.Length)
            {
                // to create a COPY of templist before adding it. As you see templist keeps getting passed on as an argument and keeps getting modified. 
                // If you just add templist, all the modifications you make to templist get reflected in the final list.
                list.Add(new List<int>(tempList));
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (tempList.Contains(nums[i]))
                {
                    continue;
                }

                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
