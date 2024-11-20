using Banking.SharedKernel;

namespace Banking.Accounting;

public class Account
{
    private Amount balance;
    private int accountNumber;
    private Customer accountOwner;

    public Account(int accountNumber, Customer accountOwner)
    {
        this.balance = Amount.Of(0);
        this.accountNumber = accountNumber;
        this.accountOwner = accountOwner;
    }

    public Amount GetBalance()
    {
        return balance;
    }

    public void SetBalance(Amount balance)
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
