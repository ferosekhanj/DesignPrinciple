using System;
using Common;
using FamilyAndFriends;
using Stranger;

namespace Law_of_demeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Family f = new Family(new Name("John","Doe"), new Name("Jane", "Doe"), new Address("21", "Beach Street", "Begur", "500001"));

            Seller s1 = new Seller("red balloon",10);
            s1.Sell(f);

            Seller s2 = new Seller("red balloon", 20);
            s2.Sell(f);
        }
    }
}
