public class BankAccount
{
    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Amount cannot be negative.");
        }
        // Deposit logic
    }
}