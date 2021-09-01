namespace Open_Closed_Principle
{
    class Driver
    {
        public string Name { get; init; }
        public string ContactNumber { get; init; }

        public string HostName { get; init; }
        public string HostContactNumber { get; init; }
        public string VehicleNumber { get; init; }
        public Driver(string name, string contactNumber, string hostName, string hostContactNumber, string vehicleNumber)
        {
            Name = name;
            ContactNumber = contactNumber;

            HostName = hostName;
            HostContactNumber = hostContactNumber;

            VehicleNumber = vehicleNumber;
        }
    }
}
