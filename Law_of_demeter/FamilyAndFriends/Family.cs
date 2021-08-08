using Common;
namespace FamilyAndFriends
{
    class Family
    {
        public Name FatherName { get; init; }
        public Name MotherName { get; init; }
        public Address Address { get; init; }

        public Family(Name fatherName, Name motherName, Address address)
        {
            FatherName = fatherName;
            MotherName = motherName;
            Address = address;
        }

        public int RequestPayment(string item, int price)
        {
            if (item == "red balloon" && price < 15)
                return 10;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"{FatherName.First},{FatherName.Family}\n{MotherName.First},{MotherName.Family}\n{Address}";
        }
    }
}