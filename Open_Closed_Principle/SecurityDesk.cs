using static System.Console;

namespace Open_Closed_Principle
{
    class SecurityDesk
    {
        public string Name { get; init; }
        public SecurityDesk(string name)
        {
            Name = name;
            WriteLine($"Security: {Name} open...");
        }
        public void Register(Guest person)
        {
            WriteLine($"{person.Name} with {person.ContactNumber} came to meet {person.HostName} {person.HostContactNumber}");
        }
    }
}