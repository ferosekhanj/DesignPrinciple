using Common;

namespace FamilyAndFriends
{
    class Child 
    {
        public Name ChildName { get; init; }
        public Family Family { get; init; }

        public Child(Name name, Family family)
        {
            ChildName = name;
            Family = family;
        }

        public int Tempt(string item, int price)
        {
            return Family.RequestPayment(price);
        }
    }
}
