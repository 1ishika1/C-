using System;
public class BestTimeToBuyAndSellStock
{
   public int MaxProfit(int[] prices)
   {
       int mini = prices[0];
       int MaxProfit = 0;
       for(int i = 0; i < prices.Length; i++)
       {
          int cost = prices[i] - mini;
          MaxProfit = Math.Max(MaxProfit, cost);
          mini = Math.Min(mini, prices[i]);
       }
       return MaxProfit;
    }
       
   public static void Main()
   {
       BestTimeToBuyAndSellStock BestSolution = new BestTimeToBuyAndSellStock();
       int[] prices = {7, 1, 3, 4, 5};
       int result = BestSolution.MaxProfit(prices);
       Console.WriteLine(result);     
    }
}