namespace LiskovSubstitutionPrinciple.System
{
    class Canteen
    {
        public void ChargeStaff(Staff staff, decimal amount)
        {
            if (staff.IsActive)
            {
                staff.ChargeExpense(amount);
            }
        }
    }
}
