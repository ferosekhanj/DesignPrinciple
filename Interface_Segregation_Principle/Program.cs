using System;

namespace Interface_Segregation_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankTeller teller = new BankTeller("John");

            DepositTeller depositClerk = teller as DepositTeller;
            depositClerk.Deposit(new DepositForm(DateTime.Now,"1234",10));

            WithdrawalTeller withdrawClerk = teller as WithdrawalTeller;
            withdrawClerk.Withdraw(new Check(DateTime.Now,"Jane","1234",10));

        }
    }
}
