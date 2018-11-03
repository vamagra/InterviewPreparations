using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    public class CoinChange
    {
        /// <summary>
        //  You are given coins of different denominations and a total amount of money amount. 
        //  Write a function to compute the fewest number of coins that you need to make up that amount. 
        //  If that amount of money cannot be made up by any 
        //  combination of the coins, return -1.
        //  Example 1:
        //  coins = [1, 2, 5], amount = 11
        //  return 3 (11 = 5 + 5 + 1)
        //  Example 2:
        //  coins = [2], amount = 3
        //  return -1.
        // </summary>
        // <param name="nums"></param>
        // <param name="amount"></param>
        // <returns></returns>
        public static int GetCoinCountChange(int[] nums, int amount)
        {
            // its traditional BFS problem
            if (nums.Length < 1)
            {
                return -1;
            }

            if (amount < 1)
            {
                return -1;
            }

            // BFS
            Queue<int> queueInt = new Queue<int>();
            int level = 1;

            bool[] visited = new bool[amount + 1];
            visited[amount] = true;

            queueInt.Enqueue(amount);

            while (queueInt.Count != 0)
            {
                int size = queueInt.Count;

                for (int j = 0; j < size; j++)
                {
                    int currValue = queueInt.Dequeue();

                    for (int i = 0; i < nums.Length; i++)
                    {
                        int child = currValue - nums[i];

                        //total amount calculated here
                        if (child == 0)
                        {
                            return level;
                        }
                        else
                        {
                            if (child > 0 && !visited[child])
                            {
                                visited[child] = true;
                                queueInt.Enqueue(child);
                            }
                        }
                    }
                }

                level++;
            }

            return -1;
        }
    }
}
