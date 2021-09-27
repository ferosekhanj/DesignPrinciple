using System;

namespace Interface_Segregation_Principle
{
    public record ExchangeCashForm(DateTime date, decimal amount);
    public interface ExchangeCashTeller
    {
        public void ExchangeCash(ExchangeCashForm form);
    }
}