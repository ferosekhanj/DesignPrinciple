namespace Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainGate = new SecurityDesk("MainGate");
            mainGate.Register(new Guest("John Doe", "123", "Thomas", "456"));
            mainGate.Register(new Guest("Jane Doe", "978", "Chandra", "785"));
        }
    }
}
