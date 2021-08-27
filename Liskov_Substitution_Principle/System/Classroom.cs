using System;

namespace LiskovSubstitutionPrinciple.System
{
    class Classroom
    {
        public void Enter(Staff staff)
        {
            if (staff.IsActive)
            {
                staff.LogEntry(DateTime.Now);
            }
        }
        public void Exit(Staff staff)
        {
            if (staff.IsActive)
            {
                staff.LogExit(DateTime.Now);
            }
        }
    }
}
