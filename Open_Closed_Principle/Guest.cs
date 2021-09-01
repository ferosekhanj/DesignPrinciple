namespace Open_Closed_Principle
{
    class Guest
    {
        public string Name { get; init; }
        public string ContactNumber { get; init; }

        public string HostName { get; init; }
        public string HostContactNumber { get; init; }

        public Guest(string name,string contactNumber, string hostName, string hostContactNumber)
        {
            Name          = name;
            ContactNumber = contactNumber;

            HostName          = hostName;
            HostContactNumber = hostContactNumber;
        }
    }
}
