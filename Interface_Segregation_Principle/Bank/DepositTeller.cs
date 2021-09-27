using System;

namespace Interface_Segregation_Principle
{
    public record DepositForm(DateTime date, string accountId, decimal amount);
    public interface DepositTeller
    {
        public void Deposit(DepositForm form);        
    }
}