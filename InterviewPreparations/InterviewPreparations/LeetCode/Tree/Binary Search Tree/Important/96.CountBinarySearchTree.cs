using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class CountBinarySearchTree
    {
        /// <summary>
        /// Given n, how many structurally unique BST's (binary search trees) that store values 1 ... n?
        //  Example:
        //  Input: 3
        //  Output: 5
        //  Explanation:
        //  Given n = 3, there are a total of 5 unique BST's:
        //   1         3     3      2      1
        //    \       /     /      / \      \
        //     3     2     1      1   3      2
        //    /     /       \                 \
        //   2     1         2                 3
        //  </summary>
        //  <param name="n"></param>
        //  <returns></returns>
        public static int UniqueBinarySearchTree(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            int[] dp = new int[n + 1];

            dp[0] = dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = 0;
                for (int j = 0; j < i; j++)
                {
                    //  in this loop we are taking possiblity of every key as root and calucalting like
                    //  if n = 4 { 4,5,6,7}, then j loop will run assuming 4 as root , 5 as root, 6 as root & 7 as root
                    //  when 4 as root dp[j] will be denote left nodes of root and dp[i-j-1] will right nodes
                    //  of the root e.g. for 4 there will be 0 nodes on the left and 3 nodes on the right
                    //  so dp[j] = dp[0] = 0 & dp[i-j-1] = dp[4-0-1] = 3 
                    //  to make the formula we need to add the all possiblities of roots and 
                    //  multiple the left and right node values
                    dp[i] += dp[j] + dp[i - j - 1];
                }
            }

            return dp[n];
        }
    }
}
