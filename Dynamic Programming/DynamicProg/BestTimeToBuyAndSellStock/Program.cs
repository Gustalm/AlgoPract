// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//[7,1,5,3,6,4]
static int MaxProfit(int[] prices)
{
    var minBuyValue = int.MaxValue;
    var maxProfit = 0;


    for(int i = 0; i < prices.Length; i++)
    {
        minBuyValue = Math.Min(minBuyValue, prices[i]);
        var currentProfit = prices[i] - minBuyValue;


        maxProfit = Math.Max(maxProfit, currentProfit);
    }

    return maxProfit;
}

