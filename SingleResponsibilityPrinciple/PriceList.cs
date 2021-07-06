using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class PriceList{
        Dictionary <string,int> itemPrice = new()
        {
            ["CowMilk"]   = 1,
            ["GoatMilk"]  = 2,
            ["CamelMilk"] = 2,
            ["Choclate"]  = 1,
            ["Biscut"]    = 1
        };

        public int FindPrice(string itemName)=> itemPrice[itemName];
    }

}