using LiskovSubstitutionPrinciple.System;

namespace LiskovSubstitutionPrinciple.Actors
{
    public class Cleaner : Staff
    {
        StaffCard myId;

        public Cleaner(string name, StaffCard idCard)
        {
            myId       = idCard;
            RollNumber = myId.RollNumber;
            IsActive   = myId.IsActive;
            Name       = name;
        }

        public override void ChargeExpense(decimal amount)
        {
            myId.AddDebt(amount);
        }
    }
}
