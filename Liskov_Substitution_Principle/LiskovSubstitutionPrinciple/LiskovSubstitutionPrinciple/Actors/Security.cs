using LiskovSubstitutionPrinciple.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Actors
{
    class Security :Staff
    {
        StaffCard myId;

        public Security(string name, StaffCard idCard)
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
