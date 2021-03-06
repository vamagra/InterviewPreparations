﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BestTimeToBuyAndSellStockII
    {
        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        //  Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times). 
        //  However, you may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
        //  </summary>
        //  <param name="prices"></param>
        //  <returns></returns>
        public static int MaxProfits(int[] prices)
        {
            int totalProfit = 0;

            if (prices.Length < 1)
            {
                return totalProfit;
            }

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    totalProfit += (prices[i] - prices[i - 1]);
                }
            }

            return totalProfit;
        }
    }
}
