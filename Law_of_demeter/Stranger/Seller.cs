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

        public void Sell(IFamilyCustomer family) 
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

        bool SellItem(IFamilyCustomer family)
        {
            // AVOID doing such implementation, it breaks law of demeter
            return family.Children[0].Tempt(Item, Price) == Price;
        }

        void PrintBill(IFamilyCustomer family,string item, int price)
        {
            Console.WriteLine($"=====\nBill:\nBill To:{family.FatherName.First}\n{family.Address}\nItem:\n{item}\t{price}\n");
        }

        void PrintWish(IFamilyCustomer family)
        {
            Console.WriteLine($"=====\nNo sale:\n See you next time {family.FatherName.First}");
        }

    }
}
