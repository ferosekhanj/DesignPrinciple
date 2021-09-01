namespace Open_Closed_Principle
{
    interface Visitor
    {
        public string Name { get; }
        public string ContactNumber { get;  }

        public string HostName { get;  }
        public string HostContactNumber { get; }
        public string Purpose { get; }
    }
}
