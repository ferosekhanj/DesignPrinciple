using LiskovSubstitutionPrinciple.System;
using System;

namespace LiskovSubstitutionPrinciple.Actors
{
    class Visitor : Staff
    {
        VisitorCard myIdCard;
        public Visitor(string name,VisitorCard idCard)
        {
            myIdCard = idCard;
            RollNumber = idCard.RollNumber;
            IsActive = idCard.IsActive;
            Name = name;
        }

        public override void ChargeExpense(decimal amount)
        {
            myIdCard.AddDebt(amount);
        }

    }
}
