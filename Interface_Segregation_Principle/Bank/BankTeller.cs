namespace Interface_Segregation_Principle
{
    class BankTeller : DepositTeller, WithdrawalTeller, ExchangeCashTeller, BankersCheckTeller
    {
        public string Name { get; set; }

        public BankTeller(string name)
        {
            Name = name;
        }
        public void Deposit(DepositForm form)
        {

        }
        public void Withdraw(Check form)
        {

        }
        public void ExchangeCash(ExchangeCashForm form)
        {

        }
        public void GetBankersCheck(BankersCheckForm form)
        {

        }
    }
}
