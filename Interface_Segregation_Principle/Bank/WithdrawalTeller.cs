using System;

namespace Interface_Segregation_Principle
{
    public record Check(DateTime date, string bearerName, string accountId, decimal amount);
    public interface WithdrawalTeller
    {
        public void Withdraw(Check form);
    }
}