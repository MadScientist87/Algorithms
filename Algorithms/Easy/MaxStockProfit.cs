using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class MaxStockProfit
    {
        public int MaxProfit(int[] prices)
        {
            var maxprofit = 0;
            for (var x = 0; x < prices.Length; x++)
            {
                var buy = prices[x];
                for (var i = x; i < prices.Length; i++)
                {
                    var sell = prices[i];
                    if (sell > buy && sell - buy > maxprofit)
                        maxprofit = sell - buy;
                }
            }

            return maxprofit;
        }

        // More efficient with one for loop
        public int MaxProfit2(int[] prices)
        {
            var maxprofit = 0;
            var buy = prices[0];

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > buy)
                {
                    if (maxprofit < (prices[i] - buy))
                    {
                        maxprofit = prices[i] - buy;
                    }
                }
                else
                {
                    buy = prices[i];
                }
            }

            return maxprofit;
        }
    }
}
