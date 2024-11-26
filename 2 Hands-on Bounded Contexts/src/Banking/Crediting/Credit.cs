using Banking.Accounting;

namespace Banking.Crediting;

public class Credit
{
    private float amountOfCredit;
    private int creditNumber;
    private Status status;
    private Customer customer;
    private CreditAccount? account;

    public enum Status
    {
        Applied, Refused, Granted, Delayed, Payed
    }

    public Credit(int creditNumber, Customer customer, float amountOfCredit)
    {
        this.amountOfCredit = amountOfCredit;
        this.creditNumber = creditNumber;
        this.customer = customer;
        this.customer.GetCreditList().Add(this);
        this.status = Status.Applied;
    }

    public float GetAmountOfCredit()
    {
        return amountOfCredit;
    }

    public void SetAmountOfCredit(float amountOfCredit)
    {
        this.amountOfCredit = amountOfCredit;
    }

    public Customer GetCustomer()
    {
        return customer;
    }

    public int GetCreditNumber()
    {
        return creditNumber;
    }

    public Status GetStatus()
    {
        return status;
    }

    public void SetStatus(Status status)
    {
        this.status = status;
    }

    public CreditAccount? GetAccount()
    {
        return account;
    }

    public void SetAccount(CreditAccount account)
    {
        this.account = account;
    }

}
