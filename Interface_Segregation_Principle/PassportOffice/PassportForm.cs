using System;

namespace Interface_Segregation_Principle
{
    public class PassportForm
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string PostalAddress { get; set; }
        public bool IsMinor { get; set; }
        public string ParentPassport { get; set; }
        public bool BiometricsRequired { get; set; }
        public bool IsSeniorCitizen { get; set; }
        public string PoliceVerificationDetails { get; set; }
        public decimal PostalCharge { get; set; }
        public bool IsGovernmentServant { get; set; }
        public string ServiceLocation { get; set; }

    }
}