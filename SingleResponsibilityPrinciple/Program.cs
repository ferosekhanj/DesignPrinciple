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

        public void SetOrder(List<int> cowMilkOrder, List<int> goatMilkOrder, List<int> camelMilkOrder,List<int> choclateOrder, List<int> biscutOrder)
        {
            cowMilkOrders.AddRange(cowMilkOrder);
            goatMilkOrders.AddRange(goatMilkOrder);
            camelMilkOrders.AddRange(camelMilkOrder);
            choclateOrders.AddRange(choclateOrder);
            biscutOrders.AddRange(biscutOrder);
        }
        public void DeliverMilk()
        {
            for (var i = 0; i <cowMilkOrders.Count; i++)
            {
                System.Console.Write($"house {i} => Cow,{cowMilkOrders[i]} Goat,{goatMilkOrders[i]} Soya,{camelMilkOrders[i]}");
                System.Console.WriteLine($" Choclate,{choclateOrders[i]} Biscut, {biscutOrders[i]}");
            }
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Milkman m1 = new Milkman();
            m1.SetOrder(new() {1,2,1},new() {0,0,1},new() {1,0,0},new(){1,1,1},new(){0,0,1});
            m1.DeliverMilk();
        }
    }
}
