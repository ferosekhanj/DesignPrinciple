using System;

namespace LiskovSubstitutionPrinciple.System
{
    public abstract class Staff
    {
        public string Name { get; init; }

        public int RollNumber { get; init;}

        public bool IsActive { get; init; }

        public void LogEntry(DateTime timeStamp) 
        {
            Console.WriteLine($"{Name} enter at {timeStamp}");
        }

        public void LogExit(DateTime timeStamp)
        {
            Console.WriteLine($"{Name} exit at {timeStamp}");
        }

        public abstract void ChargeExpense(decimal amount);

    }
}
