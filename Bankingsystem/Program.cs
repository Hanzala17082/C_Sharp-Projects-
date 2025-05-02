namespace Bankingsystem 
{
    interface Bank
    {
        abstract public void Credit (int amount);
        
        abstract public void Debit(int amount);

        abstract public bool Login(int pincode);

        abstract public void Checkbalance();
        
       

    }
}
