using LiskovSubstitutionPrinciple.System;

namespace LiskovSubstitutionPrinciple.Actors
{
    public class Teacher : Staff
    {
        StaffCard myId;

        public Teacher(string name,StaffCard idCard)
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
