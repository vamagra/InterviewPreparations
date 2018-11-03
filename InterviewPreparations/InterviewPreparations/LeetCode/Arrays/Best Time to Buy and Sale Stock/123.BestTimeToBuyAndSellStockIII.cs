using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class BestTimeToBuyAndSellStockIII
    {
        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        //  Design an algorithm to find the maximum profit. You may complete at most two transactions.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        /// 
        #region Explnation
        //First assume that we have no money, so buy1 means that we have to borrow money from others, we want to borrow less so that we have to make our balance as max as we can(because this is negative).

        //sell1 means we decide to sell the stock, after selling it we have price[i] money and we have to give back the money we owed, so we have price[i] - |buy1| = prices[i] + buy1, we want to make this max.

        //buy2 means we want to buy another stock, we already have sell1 money, so after buying stock2 we have buy2 = sell1 - price[i] money left, we want more money left, so we make it max

        //sell2 means we want to sell stock2, we can have price[i] money after selling it, and we have buy2 money left before, so sell2 = buy2 + prices[i], we make this max.

        //So sell2 is the most money we can have.
        #endregion
        public static int MaxProfits(int[] prices)
        {
            //To understand the hidden logic, you have to understand what these 4 variables stand for.
            //sell2: Final profit.
            //buy2: Best profit so far, if you buy the stock not after Day i(2nd transaction).
            //sell1: Best profit so far, if you sell the stock not after Day i(1st transaction).
            //buy1: Minimum price to buy the stock.

            int sell1 = 0, sell2 = 0, buy1 = int.MinValue, buy2 = int.MinValue;

            if (prices.Length < 1)
            {
                return 0;
            }

            for (int i = 0; i < prices.Length; i++)
            {
                // First assume that we have no money, so buy1 means that we have to borrow money from others, 
                // we want to borrow less so that we have to make our balance as max as we can(because this is negative).
                buy1 = Math.Max(buy1, -prices[i]);

                // sell1 means we decide to sell the stock, after selling it we have price[i] money and 
                // we have to give back the money we owed, so we have price[i] - |buy1| = prices[i] + buy1, we 
                // want to make this max.
                sell1 = Math.Max(sell1, buy1 + prices[i]);

                // buy2 means we want to buy another stock, we already have sell1 money, 
                // so after buying stock2 we have buy2 = sell1 - price[i] money left, 
                // we want more money left, so we make it max
                buy2 = Math.Max(buy2, sell1 - prices[i]);

                // sell2 means we want to sell stock2, we can have price[i] money after selling it, 
                // and we have buy2 money left before, so sell2 = buy2 + prices[i], we make this max.
                sell2 = Math.Max(sell2, buy2 + prices[i]);
            }

            return sell2;
        }
    }
}
