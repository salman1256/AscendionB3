namespace BankingExample
{
    internal interface IAccount
    {
        double Balance { get; }
        double Deposit(double amount);  
        double Withdraw(double amount);
    }
}
