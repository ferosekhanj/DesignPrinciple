using Common;
using System.Collections.Generic;

namespace FamilyAndFriends
{
    interface IFamilyCustomer
    {
        Name FatherName { get; init; }
        Name MotherName { get; init; }
        Address Address { get; init; }
        IReadOnlyList<Child> Children { get; }
        int RequestPayment(string item, int price);
    }
}