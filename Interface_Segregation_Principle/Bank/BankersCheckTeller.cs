using System;

namespace Interface_Segregation_Principle
{
    public record BankersCheckForm(DateTime date, string favouring, string accountId, decimal amount);
    public interface BankersCheckTeller
    {
        public void GetBankersCheck(BankersCheckForm form);
    }
}