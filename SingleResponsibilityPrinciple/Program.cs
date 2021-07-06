using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Milkman
    {
        List<int> milkOrders = new();
        public Milkman()
        {
        }

        public void SetOrder(List<int> dayOrder)
        {
            milkOrders.AddRange(dayOrder); 
        }
        public void DeliverMilk()
        {
            for (var i = 0; i <milkOrders.Count; i++)
            {
                System.Console.WriteLine($"house {i} => {milkOrders[i]}");
            }
            System.Console.WriteLine("Completed.");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Milkman m1 = new Milkman();
            m1.SetOrder(new() {1,2,1,2,1});
            m1.DeliverMilk();
        }
    }
}
