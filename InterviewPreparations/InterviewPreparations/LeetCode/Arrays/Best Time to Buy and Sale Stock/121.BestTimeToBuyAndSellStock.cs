using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BestTimeToBuyAndSellStock
    {
        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        //  If you were only permitted to complete at most one transaction(ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        //  Example 1:
        //  Input: [7, 1, 5, 3, 6, 4]
        //  Output: 5
        //  max.difference = 6 - 1 = 5 (not 7 - 1 = 6, as selling price needs to be larger than buying price)
        //  Example 2:
        //  Input: [7, 6, 4, 3, 1]
        //  Output: 0
        //  In this case, no transaction is done, i.e.max profit = 0.
        //  </summary>
        //  <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfits(int[] prices)
        {
            int totalProfit = 0;
            int currprofit = 0;

            if (prices.Length < 1)
            {
                return 0;
            }

            int minBuyPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > minBuyPrice)
                {
                    currprofit = prices[i] - minBuyPrice;
                    totalProfit = currprofit > totalProfit ? currprofit : totalProfit;
                }
                else
                {
                    minBuyPrice = prices[i] > minBuyPrice ? minBuyPrice : prices[i];
                }
            }

            return totalProfit > 0 ? totalProfit : 0;
        }
    }
}
