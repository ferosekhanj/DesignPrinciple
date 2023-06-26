namespace Hidden_logical_dependecy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car honda = new Car();
            Console.WriteLine($"Door => Locked={honda.Doors[0].Locked}");

            // enable child lock
            honda.Doors[0].ChildLock = true;

            // Open from the outside
            honda.Doors[0].Open(false);
            Console.WriteLine($"Door.Open() => Locked={honda.Doors[0].Locked}");

            // Close door
            honda.Doors[0].Close();
            Console.WriteLine($"Door.Close() => Locked={honda.Doors[0].Locked}");

            // Open from the inside
            honda.Doors[0].Open(true);
            Console.WriteLine($"Door.Open() => Locked={honda.Doors[0].Locked}");

            // Close door
            honda.Doors[0].Close();
            Console.WriteLine($"Door.Close() => Locked={honda.Doors[0].Locked}");
        }
    }
}