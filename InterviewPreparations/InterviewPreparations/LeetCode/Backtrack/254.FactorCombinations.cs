using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FactorCombinations
    {
        /// <summary>
        /// Numbers can be regarded as product of its factors. For example,
        //  8 = 2 x 2 x 2;
        //  = 2 x 4.
        //  Write a function that takes an integer n and return all possible combinations of its factors.
        //  Note:
        //  You may assume that n is always positive.
        //  Factors should be greater than 1 and less than n.
        //  </summary>
        //  <param name="n"></param>
        //  <returns></returns>
        public static List<List<int>> GetAllFactorCombinations(int n)
        {
            List<List<int>> result = new List<List<int>>();

            // Finding one combination is straightforward, all you would do is, in a loop, check if 
            // modulo of 'n' to each number is zero, if it is, then you have a combination.
            // Our approach to solving the problem involves little extension using recursion where everytime 
            // we find a 'j' where n/ j = 0, we pass the n/ j as 'n' to the method.We recurse until n<= 1.
            GetFactors(2, n, new List<int>(), result);

            return result;
        }

        public static void GetFactors(int start, int n, List<int> temp, List<List<int>> result)
        {
            // When n<=1, we reach the end of one recursion, so we add temp to main result.
            if (n <= 1)
            {
                // when temp.Count is greater than 1 to avoid adding number itself like if n = 8, 
                //  don't add 8 itself in the list
                if (temp.Count > 1)
                {
                    result.Add(new List<int>(temp));
                }
            }

            for (int i = start; i <= n; i++)
            {
                // When n%i is 0, pass n/i as 'n'
                if (n % i == 0)
                {
                    temp.Add(i);
                    GetFactors(i, n / i, temp, result);
                    // This step is important to remove the older entry and generate a new combination of factors.
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
    }
}
