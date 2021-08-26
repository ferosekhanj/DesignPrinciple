using LiskovSubstitutionPrinciple.Actors;
using LiskovSubstitutionPrinciple.System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var staffs = new List<Staff>()
            {
                new Cleaner("c1", new StaffCard(1,true,100)),
                new Teacher("t1", new StaffCard(2, true, 500)),
                new Security("s1", new StaffCard(3, true, 300)),
                new Visitor("John Doe", new VisitorCard(1001))
            };

            var canteen = new Canteen();
            var classRoom = new Classroom();
            var library = new Library();

            staffs.ForEach(staff => canteen.ChargeStaff(staff,10));
            staffs.ForEach(staff => classRoom.Enter(staff));
            staffs.ForEach(staff => classRoom.Exit(staff));


        }
    }
}
