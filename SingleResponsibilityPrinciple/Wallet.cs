namespace SingleResponsibilityPrinciple
{
    class Wallet
    {
        int balance;
        int debt;
        
        public Wallet(int initialAmount)
        {
            balance = initialAmount;
        }
        public void AddMoney(int amount)=> balance = balance + amount - debt;
        
        public bool GetPayment(int orderAmount)
        {
            if(balance < orderAmount )
            {
                if( balance >= orderAmount/2 )
                {
                    debt = orderAmount - balance;
                    balance = 0;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                balance = balance - orderAmount;
            }
            return true;
        }
    }

}