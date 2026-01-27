public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = prices[0];
        int bestProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            int profitToday = prices[i] - minPrice;
            bestProfit = Math.Max(bestProfit, profitToday);

            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
        }

        return bestProfit;
    }
}

//explication de logic

// On garde 2 variables :
// minPrice = le plus petit prix vu jusqu’à maintenant (meilleur jour pour acheter)
// bestProfit = le meilleur profit trouvé jusqu’à maintenant
// Au début :
// minPrice = prix du jour 0
// bestProfit = 0
// Puis on avance jour par jour :
// Pour chaque prix p :
// Profit si je vends aujourd’hui = p - minPrice
// Si ce profit est meilleur → je mets à jour bestProfit
// Si p est plus petit que minPrice → je mets à jour minPrice

//Alors on nous met en pratique => prices = [7, 1, 5, 3, 6, 4]

// day 0
// minprice = 7
// best profit = 0
// day 1
// minprice = 1
// best profit = 0
// day 2
// minprice = 1
// best profit = 5-1=4
// day 3
// minprice = 1
// best profit = 4
// day 4
// minprice = 1
// best profit = 6-1=5
// day 5
// minprice = 1
// best profit = 4

// donc best profit = 5
