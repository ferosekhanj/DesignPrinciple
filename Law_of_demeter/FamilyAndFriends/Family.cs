using Common;
using System.Collections.Generic;

namespace FamilyAndFriends
{
    class Family : IFamilyCustomer
    {
        public Name FatherName { get; init; }
        public Name MotherName { get; init; }
        public Address Address { get; init; }

        public IReadOnlyList<Child> Children => children.AsReadOnly();

        private readonly List<Child> children = new List<Child>();

        private int balanceMoney;

        public Family(Name fatherName, Name motherName, Address address)
        {
            FatherName = fatherName;
            MotherName = motherName;
            Address = address;
            balanceMoney = 100;
        }

        public void AddChild(Name childName)
        {
            children.Add(new Child(childName, this));
        }

        public int RequestPayment(string item, int price)
        {
            if (item == "red balloon" && price < 15 && balanceMoney > price)
            {
                balanceMoney = balanceMoney - price;
                return 10;
            }
            else
            {
                return 0;
            }
        }

        internal int RequestPayment(int amount)
        {
            return (amount < balanceMoney) ? amount : 0;
        }

        public override string ToString()
        {
            return $"{FatherName.First},{FatherName.Family}\n{MotherName.First},{MotherName.Family}\n{Address}";
        }
    }
}