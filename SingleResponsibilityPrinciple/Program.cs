using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    enum MilkType
    {
        Cow,
        Goat,
        Soya
    }
    class Milkman
    {
        List<int> milkOrders = new();
        List<MilkType> milkOrderTypes = new();
        public Milkman()
        {
        }

        public void SetOrder(List<int> dayOrder,List<MilkType> dayOrderType)
        {
            milkOrders.AddRange(dayOrder);
            milkOrderTypes.AddRange(dayOrderType);
        }
        public void DeliverMilk()
        {
            for (var i = 0; i <milkOrders.Count; i++)
            {
                System.Console.WriteLine($"house {i} => {milkOrderTypes[i]},{milkOrders[i]}");
            }
            System.Console.WriteLine("Completed.");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Milkman m1 = new Milkman();
            m1.SetOrder(new() {1,2,1},new(){MilkType.Cow,MilkType.Goat,MilkType.Goat});
            m1.DeliverMilk();
        }
    }
}
