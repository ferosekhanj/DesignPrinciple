using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new()
            {
                 new Order(new(){["CowMilk"]  =1,["Choclate"] =1}),
                 new Order(new(){["CamelMilk"]=4,["Biscut"]   =1}),
                 new Order(new(){["Biscut"]   =2,["Choclate"] =1}),
            };

            List<Wallet> wallets = new(){
                new Wallet(100),
                new Wallet(1),
                new Wallet(50)
            };

            Milkman m1 = new Milkman(orders,new PriceList(),wallets);
            m1.DeliverMilk();
        }
    }
}
