using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Milkman
    {
        List<int> cowMilkOrders = new();
        List<int> goatMilkOrders = new();
        List<int> soyaMilkOrders = new();

        public void SetOrder(List<int> cowMilkOrder, List<int> goatMilkOrder, List<int> soyaMilkOrder)
        {
            cowMilkOrders.AddRange(cowMilkOrder);
            goatMilkOrders.AddRange(goatMilkOrder);
            soyaMilkOrders.AddRange(soyaMilkOrder);
        }
        public void DeliverMilk()
        {
            for (var i = 0; i <cowMilkOrders.Count; i++)
            {
                System.Console.WriteLine($"house {i} => Cow,{cowMilkOrders[i]} Goat,{goatMilkOrders[i]} Soya,{soyaMilkOrders[i]}");
            }
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Milkman m1 = new Milkman();
            m1.SetOrder(new() {1,2,1},new() {0,0,1},new() {1,0,0});
            m1.DeliverMilk();
        }
    }
}
