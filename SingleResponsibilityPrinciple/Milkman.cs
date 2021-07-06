using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Milkman
    {
        List<Order> orders;
        PriceList priceList;
        List<Wallet> walletBalances ;

        public Milkman(List<Order> dayOrder, PriceList dayPriceList, List<Wallet> walletInfo)
        {
            orders = dayOrder;
            priceList = dayPriceList;
            walletBalances = walletInfo;
        }
        public void DeliverMilk()
        {
            for (var i = 0; i <orders.Count; i++)
            {
                if(walletBalances[i].GetPayment(orders[i].CalculatePrice(priceList)))
                {
                    System.Console.WriteLine($"house {i} => {orders[i]}");
                }
                else
                {
                    System.Console.WriteLine($"house {i} => Not enough cash to buy the order.");
                }
            }
        }
    } 
}