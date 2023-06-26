namespace Hidden_logical_dependecy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car honda = new Car();
            Console.WriteLine($"Door => Locked={honda.Doors[0].Locked}");

            // Open from the outside
            honda.Doors[0].OpenFromOutside();
            Console.WriteLine($"Door.OpenFromOutside() => Locked={honda.Doors[0].Locked}");

            // Close door
            honda.Doors[0].Close();
            Console.WriteLine($"Door.Close() => Locked={honda.Doors[0].Locked}");

            // Open from the inside with child lock
            honda.Doors[0].OpenFromInside(true);
            Console.WriteLine($"Door.OpenFromInside(childlock=T) => Locked={honda.Doors[0].Locked}");

            // Open from the inside
            honda.Doors[0].OpenFromInside(false);
            Console.WriteLine($"Door.OpenFromInside(childlock=F) => Locked={honda.Doors[0].Locked}");

            // Close door
            honda.Doors[0].Close();
            Console.WriteLine($"Door.Close() => Locked={honda.Doors[0].Locked}");
        }
    }
}