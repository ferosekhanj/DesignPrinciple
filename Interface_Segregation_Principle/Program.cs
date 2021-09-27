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

            // Apply for a kids passport
            var form = new PassportForm
            {
                Name = "Khan",
                DateOfBirth = DateTime.Now,
                IsMinor = true,
                ParentPassport = "ABC123",
                BiometricsRequired = false,
                IsGovernmentServant = false,
                IsSeniorCitizen = false,
                PlaceOfBirth = "Bangalore",
                PoliceVerificationDetails = null,
                PostalAddress = "1, one street, Pin-5600021",
                PostalCharge = 10,
                ServiceLocation = null
            };
            PassportOfficer officer = new PassportOfficer("Tom");
            officer.Apply(form);
            //officer.SubmitBiometrics(form); throws error
            officer.CollectAcknowledgement(form);

        }
    }
}
