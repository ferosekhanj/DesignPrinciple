using System;

namespace LiskovSubstitutionPrinciple.System
{
    public class StaffCard
    {
        public int RollNumber { get; init; }
        public bool IsActive { get; init; }

        decimal debt;
        public decimal Debt => debt;

        public StaffCard(int rollNumber, bool isActive, decimal currentDebt)
        {
            RollNumber = rollNumber;
            IsActive = isActive;
            debt = currentDebt;
        }

        public void AddDebt(decimal amount)
        {
            debt = debt + amount;
            Console.WriteLine($"Added {amount} and current debt is {Debt}");
        }
    }
}
