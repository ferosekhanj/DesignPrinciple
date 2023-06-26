namespace Hidden_logical_dependecy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car honda = new Car();
            Console.WriteLine($"Door => Locked={honda.Doors[0].Locked}");

            honda.Doors[0].Open();
            Console.WriteLine($"Door.Open() => Locked={honda.Doors[0].Locked}");

            honda.Doors[0].Close();
            Console.WriteLine($"Door.Close() => Locked={honda.Doors[0].Locked}");
        }
    }
}