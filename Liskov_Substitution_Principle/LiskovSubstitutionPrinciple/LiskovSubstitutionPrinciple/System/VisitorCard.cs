using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.System
{
    class VisitorCard
    {
        public int RollNumber { get; init; }
        public bool IsActive { get; init; }

        decimal debt;
        public decimal Debt => debt;

        public VisitorCard(int deptartmentId)
        {
            RollNumber = deptartmentId;
            IsActive = true;
            debt = 0; 
        }

        public void AddDebt(decimal amount)
        {
            debt = debt + amount;
            Console.WriteLine($"Added {amount} and current debt is {Debt}");
        }

    }
}
