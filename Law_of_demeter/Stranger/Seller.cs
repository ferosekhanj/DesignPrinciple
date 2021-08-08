using System;
using FamilyAndFriends;

namespace Stranger
{
    class Seller
    {
        public string Item { get; init; }
        public int Price { get; init; }

        public Seller(string item,int price)
        {
            Item = item;
            Price = price;
        }

        public void Sell(Family family) 
        {
            Console.WriteLine($"Attempt to sell {Item} for {Price}");
            if (SellItem(family))
            {
                PrintBill(family, Item, Price);
            }
            else
            {
                PrintWish(family);
            }
        }

        bool SellItem(Family family)
        {
            return family.RequestPayment(Item,Price) > 0;
        }

        void PrintBill(Family family,string item, int price)
        {
            Console.WriteLine($"=====\nBill:\nBill To:{family.FatherName.First}\n{family.Address}\nItem:\n{item}\t{price}\n");
        }

        void PrintWish(Family family)
        {
            Console.WriteLine($"=====\nNo sale:\n See you next time {family.FatherName.First}");
        }

    }
}
