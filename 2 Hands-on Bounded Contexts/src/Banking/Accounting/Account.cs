namespace Banking.Accounting;

public class Account
{
    private float balance;
    private int accountNumber;
    private Customer accountOwner;

    public Account(int accountNumber, Customer accountOwner)
    {
        this.balance = 0;
        this.accountNumber = accountNumber;
        this.accountOwner = accountOwner;
    }

    public float GetBalance()
    {
        return balance;
    }

    public void SetBalance(float balance)
    {
        this.balance = balance;
    }

    public int GetAccountnumber()
    {
        return accountNumber;
    }

    public Customer GetAccountowner()
    {
        return accountOwner;
    }

}
