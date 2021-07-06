using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    class Order
    {
        Dictionary <string,int> items;
        public Order(Dictionary<string,int> orderItems)
        {
            items = new Dictionary<string, int>(orderItems);
        }
        public int CalculatePrice(PriceList priceList)
        {
            int price = 0;
            foreach(var itemName in items.Keys)
            {
                price = price + priceList.FindPrice(itemName) * items[itemName];
            }
            return price;
        }
        public override string ToString()
        {
            StringBuilder str = new(""); 

            foreach(var itemName in items.Keys)
            {
                str.Append($"{itemName}={items[itemName]} ");
            }
            return str.ToString();
        }
    }
}