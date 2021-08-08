using Common;
using System.Collections.Generic;

namespace FamilyAndFriends
{
    interface IFamilyCustomer
    {
        Address Address { get; init; }
        Name FatherName { get; init; }
        Name MotherName { get; init; }
        IReadOnlyList<Child> Children { get; }
        int RequestPayment(string item, int price);
    }
}