namespace Interface_Segregation_Principle
{
    class PassportOfficer
    {
        public string Name { get; set; }

        public PassportOfficer(string name)
        {
            Name = name;
        }
        public void Apply(PassportForm form)
        {

        }

        public void SubmitBiometrics(PassportForm form)
        {

        }

        public void CollectAcknowledgement(PassportForm form)
        {

        }

    }
}
