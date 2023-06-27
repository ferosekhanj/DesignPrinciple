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
            honda.Doors[0].ActivateChildLock();
            Console.WriteLine($"Door.ActivateChildLock() => ChildLock={honda.Doors[0].ChildLock}");
            honda.Doors[0].OpenFromInside();
            Console.WriteLine($"Door.OpenFromInside() => Locked={honda.Doors[0].Locked}");

            // Open from the inside without child lock
            honda.Doors[0].DeactivateChildLock();
            Console.WriteLine($"Door.DeactivateChildLock() => ChildLock={honda.Doors[0].ChildLock}");
            honda.Doors[0].OpenFromInside();
            Console.WriteLine($"Door.OpenFromInside() => Locked={honda.Doors[0].Locked}");

            // Close door
            honda.Doors[0].Close();
            Console.WriteLine($"Door.Close() => Locked={honda.Doors[0].Locked}");
        }
    }
}