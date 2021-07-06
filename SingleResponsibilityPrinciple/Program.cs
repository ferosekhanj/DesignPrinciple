using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Milkman
    {
        List<int> cowMilkOrders = new();
        List<int> goatMilkOrders = new();
        List<int> camelMilkOrders = new();
        List<int> choclateOrders = new();
        List<int> biscutOrders = new();
        List<int> walletBalances = new();

        int cowMilkPrice = 1;
        int goatMilkPrice = 2;
        int camelMilkPrice = 2;
        int choclatePrice = 1;
        int biscutPrice = 1;

        public void SetOrder(List<int> cowMilkOrder, List<int> goatMilkOrder, List<int> camelMilkOrder,List<int> choclateOrder, List<int> biscutOrder,List<int> walletBalance)
        {
            cowMilkOrders.AddRange(cowMilkOrder);
            goatMilkOrders.AddRange(goatMilkOrder);
            camelMilkOrders.AddRange(camelMilkOrder);
            choclateOrders.AddRange(choclateOrder);
            biscutOrders.AddRange(biscutOrder);
            walletBalances.AddRange(walletBalance);
        }
        public void DeliverMilk()
        {
            int price = 0;
            for (var i = 0; i <cowMilkOrders.Count; i++)
            {
                price = (cowMilkOrders[i] * cowMilkPrice) +
                        (goatMilkOrders[i] * goatMilkPrice) +
                        (camelMilkOrders[i] * camelMilkPrice) +
                        (choclateOrders[i] * choclatePrice) +
                        (biscutOrders[i] * biscutPrice);
                if(price < walletBalances[i])
                {
                    System.Console.Write($"house {i} => Cow,{cowMilkOrders[i]} Goat,{goatMilkOrders[i]} Soya,{camelMilkOrders[i]}");
                    System.Console.WriteLine($" Choclate,{choclateOrders[i]} Biscut, {biscutOrders[i]}");
                    walletBalances[i] = walletBalances[i] - price;
                }
                else
                {
                    System.Console.WriteLine("house {i} => Not enough cash to buy the order.");
                }
            }
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Milkman m1 = new Milkman();
            m1.SetOrder(new() {1,2,1},new() {0,0,1},new() {1,0,0},new(){1,1,1},new(){0,0,1},new(){100,1,100});
            m1.DeliverMilk();
        }
    }
}
