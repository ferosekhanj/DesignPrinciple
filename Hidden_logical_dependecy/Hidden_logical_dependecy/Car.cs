using System;
using System.Collections.Generic;
using System.Linq;
namespace Hidden_logical_dependecy
{
    /// <summary>
    /// The car class.
    /// </summary>
    public class Car
    {
        public Door[] Doors {get;init;} = new Door[4];

        public Car()
        {
            //create doors
            for(int i = 0; i < Doors.Length; i++)
            {
                Doors[i] = new Door();
            }
        }
    }
}
