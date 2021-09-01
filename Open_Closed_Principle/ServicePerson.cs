namespace Open_Closed_Principle
{
    class ServicePerson :Visitor
    {
        public string Name { get; init; }
        public string ContactNumber { get; init; }

        public string HostName { get; init; }
        public string HostContactNumber { get; init; }
        public string ServiceInfo { get; init; }

        public string Purpose => $"Servicing {ServiceInfo}";

        public ServicePerson(string name, string contactNumber, string hostName, string hostContactNumber,string serviceInfo)
        {
            Name = name;
            ContactNumber = contactNumber;

            HostName = hostName;
            HostContactNumber = hostContactNumber;

            ServiceInfo = serviceInfo;
        }

    }
}
