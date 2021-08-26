using LiskovSubstitutionPrinciple.System;
using System;

namespace LiskovSubstitutionPrinciple.Actors
{
    class Visitor : Staff
    {
        public Visitor(string name)
        {
            RollNumber = -1;
            IsActive = true;
            Name = name;
        }

        public override void ChargeExpense(decimal amount)
        {
            //do nothing
            Console.WriteLine("I don't have a means to pay.");
        }

    }
}
